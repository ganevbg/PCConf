namespace PCConf.Web.Utilities
{
    using AutoMapper;
    using PCConf.Models.Parts;
    using PCConf.Web.Models;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AllowNullDestinationValues = true;

            CreateMap<Processor, ProcessorUpsertModel>().ReverseMap();
        }
    }
}
