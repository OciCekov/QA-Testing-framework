namespace TestingFramework.Core.Models
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class Auditorium
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Capacity { get; set; }

        public string Equipment { get; set; }

        public static Auditorium Parse(HtmlTableRow tableRow)
        {
            return new Auditorium
            {
                Id = int.Parse(tableRow.Cells[0].TextContent),
                Name = tableRow.Cells[1].TextContent,
                Address = tableRow.Cells[2].TextContent,
                Capacity = tableRow.Cells[3].TextContent,
                Equipment = tableRow.Cells[4].TextContent
            };
        }
    }
}
