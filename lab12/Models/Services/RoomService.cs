using lab12.Data;
using lab12.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab12.Models.Services
{
    public class RoomService : IRoom
    {
        private readonly AsyncInnContext _context;

        public RoomService(AsyncInnContext context)
        {
            _context = context;
        }
        public async Task<Room> CreateRoom(Room room)
        {
            _context.rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }
        public async Task<List<Room>> GetRoomAsync()
        {
            var allRooms = await _context.rooms.ToListAsync();
            return allRooms;
        }

        public async Task Delete(int id)
        {
            Room room = await GetRoomById(id);
            _context.Entry(room).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }


        public async Task<Room> UpdateRoom(Room room, int id)
        {
                
            var existingRoom = await _context.rooms.FindAsync(id);

            if (existingRoom == null)
            {


                throw new("Course not found");
            }
            existingRoom.Name = room.Name;
            existingRoom.Layout = room.Layout;

            await _context.SaveChangesAsync();

            return existingRoom;
        }

        public async Task<Room> GetRoomById(int id)
        {
            Room room = await _context.rooms.FindAsync(id);
            return room;
        }

     
    }
}
