using AutoMapper;
using CoreClient.ShellModels;
using WCFCore.DataContracts;

namespace InjectingCoreLibrary.MapperCore.Profiles
{
    internal class MainMapperProfile : Profile
    {
        public MainMapperProfile()
        {
            CreateMap<UserInfoModel, UserInfoDataContract>();
            CreateMap<UserInfoModel, UserInfoDataContract>().ReverseMap();

            CreateMap<PositionModel, PositionDataContract>();
            CreateMap<PositionModel, PositionDataContract>().ReverseMap();

            CreateMap<UserModel, UserDataContract>();
            CreateMap<UserModel, UserDataContract>().ReverseMap();

            CreateMap<PermissionModel, PermissionDataContract>();
            CreateMap<PermissionModel, PermissionDataContract>().ReverseMap();

            CreateMap<PositionPermissionModel, PositionPermissionDataContract>();
            CreateMap<PositionPermissionModel, PositionPermissionDataContract>().ReverseMap();
        }
    }
}
