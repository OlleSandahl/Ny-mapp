namespace BusinessEntities
{
    interface IBook
    {
        bool Availability { get; set; }
        bool Choose { get; set; }
        int ISBN { get; set; }
        State state { get; set; }
        string Title { get; set; }

        void Loan();
        void Return();
    }
}