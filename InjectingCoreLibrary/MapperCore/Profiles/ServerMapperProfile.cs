using AutoMapper;
using EFCore.Entities;
using MSAccessCore.AccessDataModels;
using WCFCore.DataContracts;

namespace InjectingCoreLibrary.MapperCore.Profiles
{
    public class ServerMapperProfile : Profile
    {
        public ServerMapperProfile()
        {
            #region EF Core - obsolete
            //CreateMap<UserInfo, UserInfoDataContract>();
            //CreateMap<UserInfo, UserInfoDataContract>().ReverseMap();

            //CreateMap<Position, PositionDataContract>();
            //CreateMap<Position, PositionDataContract>().ReverseMap();

            //CreateMap<User, UserDataContract>();
            //CreateMap<User, UserDataContract>().ReverseMap();

            //CreateMap<Permission, PermissionDataContract>();
            //CreateMap<Permission, PermissionDataContract>().ReverseMap();

            //CreateMap<PositionPermission, PositionPermissionDataContract>();
            //CreateMap<PositionPermission, PositionPermissionDataContract>().ReverseMap();
            #endregion

            #region Access Core
            CreateMap<UserInfoAD, UserInfoDataContract>();
            CreateMap<UserInfoAD, UserInfoDataContract>().ReverseMap();

            CreateMap<PositionAD, PositionDataContract>();
            CreateMap<PositionAD, PositionDataContract>().ReverseMap();

            CreateMap<RequestTypeAD, RequestTypeDataContract>();
            CreateMap<RequestTypeAD, RequestTypeDataContract>().ReverseMap();

            CreateMap<UserAD, UserDataContract>();
            CreateMap<UserAD, UserDataContract>().ReverseMap();

            CreateMap<PermissionAD, PermissionDataContract>();
            CreateMap<PermissionAD, PermissionDataContract>().ReverseMap();

            CreateMap<PositionPermissionAD, PositionPermissionDataContract>();
            CreateMap<PositionPermissionAD, PositionPermissionDataContract>().ReverseMap();
            #endregion
        }
    }
}
