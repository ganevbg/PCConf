namespace PCConf.Web.Models
{
    using PCConf.Models.Parts;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ProcessorUpsertModel : Processor, IValidatableObject
    {

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Brand == null || Brand.Id == null)
            {
                yield return new ValidationResult("Field Brand is required", new[] { "Brand" });
            }

            if (CpuSocket == null || CpuSocket.Id == null)
            {
                yield return new ValidationResult("Field Socket is required", new[] { "CpuSocket" });
            }

            if (RamType == null || RamType.Id == null)
            {
                yield return new ValidationResult("Field Ram Type is required", new[] { "RamType" });
            }

            if (PhysicalCores < 1)
            {
                yield return new ValidationResult("Field PhysicalCores is required and it have to be positive", new[] { "PhysicalCores" });
            }

            if (LogicalCores < 1)
            {
                yield return new ValidationResult("Field LogicalCores is required and it have to be positive", new[] { "LogicalCores" });
            }

            if (Frequency < 1)
            {
                yield return new ValidationResult("Field Frequency is required and it have to be positive", new[] { "Frequency" });
            }

            if (TurboBoostFrequency < 1)
            {
                yield return new ValidationResult("Field TurboBoostFrequency is required and it have to be positive", new[] { "TurboBoostFrequency" });
            }

            if (Cache < 1)
            {
                yield return new ValidationResult("Field Cache is required and it have to be positive", new[] { "Cache" });
            }
        }
    }
}
