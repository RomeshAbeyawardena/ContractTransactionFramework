using AutoMapper;
using ContractTransactionFramework.Features.Contract;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.Contract;
namespace ContractTransactionFramework.Core.Features.Contract;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.Contract, Post>();
        CreateMap<PersistenceModels.Contract, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.Contract,PersistenceModels.Contract>().ReverseMap();
    }
}
