﻿namespace MyTelegram.GatewayServer.Services;

public class ClientData : IClientData
{
    public ProtocolType MtProtoType { get; set; }
    public bool IsFirstPacketParsed { get; set; }
    public byte[] SendKey { get; set; } = null!;
    public byte[] ReceiveKey { get; set; } = null!;
    public CtrState SendCtrState { get; set; } = null!;
    public CtrState ReceiveCtrState { get; set; } = null!;
    public long AuthKeyId { get; set; }
    public string ConnectionId { get; set; } = null!;
    public bool ObfuscationEnabled { get; set; }
    public ConnectionContext? ConnectionContext { get; set; }
    public WebSocket? WebSocket { get; set; }
    public int CurrentPacketLength { get; set; }
    public int SkipCount { get; set; }
    public ClientType ClientType { get; set; }
    public string? ClientIp { get; set; }

    //public IAesCtrHelper SendAesCtrHelper { get; set; } = null!;
    //public IAesCtrHelper ReceiveAesCtrHelper { get; set; } = null!;

    //public ArrayPool<byte> ArrayPool { get; set; } = ArrayPool<byte>.Shared;
}