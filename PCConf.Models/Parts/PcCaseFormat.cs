namespace PCConf.Models.Parts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class PcCaseFormat : IEqualityComparer<PcCaseFormat>
    {
        public Guid PcCaseId { get; set; }

        public PcCase PcCase { get; set; }

        public Guid FormatId { get; set; }

        public Format Format { get; set; }

        public bool Equals([AllowNull] PcCaseFormat x, [AllowNull] PcCaseFormat y)
        {
            return x.FormatId.Equals(y.FormatId);
        }

        public int GetHashCode([DisallowNull] PcCaseFormat obj)
        {
            throw new NotImplementedException();
        }
    }
}
