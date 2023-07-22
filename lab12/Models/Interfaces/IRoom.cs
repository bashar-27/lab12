namespace lab12.Models.Interfaces
{
    public interface IRoom
    {
        //Create
        Task<Room> CreateRoom(Room room);

        //Get All Room
        Task<List<Room>> GetRoomAsync();
        //Get Room By ID
        Task<Room> GetRoomById(int roomId);

        //Update
        Task<Room> UpdateRoom(Room room, int id);

        //Delete
        Task Delete(int id);
    }
}
