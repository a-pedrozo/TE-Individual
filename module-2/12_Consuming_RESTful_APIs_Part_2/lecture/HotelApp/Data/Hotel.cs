namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    public class Hotel
    {
        public Hotel(int id)
        {
            this.Id = id;
        }

        public Hotel()  //RestSharp needs a parameterless constructor 
        {

        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public int RoomsAvailable { get; set; }
        public string CoverImage { get; set; }
    }
}
