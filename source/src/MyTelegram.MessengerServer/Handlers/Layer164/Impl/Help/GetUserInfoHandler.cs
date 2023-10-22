using MyTelegram.Handlers.Help;

namespace MyTelegram.MessengerServer.Handlers.Impl.Help;

public class GetUserInfoHandler : RpcResultObjectHandler<RequestGetUserInfo, IUserInfo>,
    IGetUserInfoHandler
{
    protected override Task<IUserInfo> HandleCoreAsync(IRequestInput input,
        RequestGetUserInfo obj)
    {
        throw new NotImplementedException();
    }
}