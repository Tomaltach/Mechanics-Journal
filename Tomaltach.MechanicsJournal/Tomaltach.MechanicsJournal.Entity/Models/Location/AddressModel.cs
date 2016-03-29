namespace Tomaltach.MechanicsJournal.Entity.Models.Location
{
    public class AddressModel
    {
        /// <summary>
        /// Address Line 1
        /// </summary>
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Address Line 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address Line 3
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// County
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Province
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Zip Code
        /// </summary>
        public string ZipCode { get; set; }
    }
}
