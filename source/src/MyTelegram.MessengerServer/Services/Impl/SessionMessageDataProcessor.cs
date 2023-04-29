﻿namespace MyTelegram.MessengerServer.Services.Impl;

public class SessionMessageDataProcessor : IDataProcessor<ISessionMessage>
{
    private readonly IEventBus _eventBus;

    public SessionMessageDataProcessor(IEventBus eventBus)
    {
        _eventBus = eventBus;
    }

    public async Task ProcessAsync(ISessionMessage data)
    {
        switch (data)
        {
            case DataResultResponseReceivedEvent dataResultResponseReceivedEvent:
                await _eventBus.PublishAsync(dataResultResponseReceivedEvent);
                break;
            case FileDataResultResponseReceivedEvent fileDataResultResponseReceivedEvent:
                await _eventBus.PublishAsync(fileDataResultResponseReceivedEvent);
                break;
            case PushMessageToPeerEvent pushMessageToPeerEvent:
                await _eventBus.PublishAsync(pushMessageToPeerEvent);
                break;
            case LayeredAuthKeyIdMessageCreatedIntegrationEvent pushSessionMessageToAuthKeyIdEvent:
                await _eventBus.PublishAsync(pushSessionMessageToAuthKeyIdEvent);
                break;
            case LayeredPushMessageCreatedIntegrationEvent pushSessionMessageToPeerEvent:
                await _eventBus.PublishAsync(pushSessionMessageToPeerEvent);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(data));
        }
    }
}