using System;

namespace Database.Db
{

    public record State
    {
        public int Id { get; set; }
        public string PropName { get; set; } = "";
        public int? IntValue { get; set; } = null;
        public string? StringValue { get; set; } = null;
        public double? DoubleValue { get; set; } = null;
    }

}
