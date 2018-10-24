namespace Zoo.Interfaces
{
    public interface ISleep
    {
        /// <summary>
        /// property
        /// </summary>
        bool Asleep { get; set; }

        /// <summary>
        /// method
        /// </summary>
        /// <returns>string</returns>
        string Nap();
    }
}
