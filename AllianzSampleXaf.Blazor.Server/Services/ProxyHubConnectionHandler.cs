using DevExpress.ExpressApp.Blazor.Services;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;

namespace AllianzSampleXaf.Blazor.Server.Services;

internal class ProxyHubConnectionHandler<THub>(
    HubLifetimeManager<THub> lifetimeManager,
    IHubProtocolResolver protocolResolver,
    IOptions<HubOptions> globalHubOptions,
    IOptions<HubOptions<THub>> hubOptions,
    ILoggerFactory loggerFactory,
    IUserIdProvider userIdProvider,
    IServiceScopeFactory serviceScopeFactory,
    IValueManagerStorageContainerInitializer storageContainerAccessor) : HubConnectionHandler<THub>(lifetimeManager, protocolResolver, globalHubOptions, hubOptions, loggerFactory, userIdProvider, serviceScopeFactory) where THub : Hub
{
    private readonly IValueManagerStorageContainerInitializer storageContainerInitializer = storageContainerAccessor;

    public override Task OnConnectedAsync(ConnectionContext connection)
    {
        storageContainerInitializer.Initialize();
        return base.OnConnectedAsync(connection);
    }
}
