namespace PCConf.Models.Parts
{
    using System;

    public class PcCaseFormat
    {
        public Guid PcCaseId { get; set; }

        public PcCase PcCase { get; set; }

        public Guid FormatId { get; set; }

        public Format Format { get; set; }
    }
}
