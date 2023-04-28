﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Bots;

///<summary>
///See <a href="https://core.telegram.org/method/bots.getBotInfo" />
///</summary>
[TlObject(0xdcd914fd)]
public sealed class RequestGetBotInfo : IRequest<MyTelegram.Schema.Bots.IBotInfo>
{
    public uint ConstructorId => 0xdcd914fd;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser? Bot { get; set; }
    public string LangCode { get; set; }

    public void ComputeFlag()
    {
        if (Bot != null) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { Bot.Serialize(bw); }
        bw.Serialize(LangCode);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Bot = br.Deserialize<MyTelegram.Schema.IInputUser>(); }
        LangCode = br.Deserialize<string>();
    }
}