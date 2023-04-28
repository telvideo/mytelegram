﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/recentMeUrlChatInvite" />
///</summary>
[TlObject(0xeb49081d)]
public sealed class TRecentMeUrlChatInvite : IRecentMeUrl
{
    public uint ConstructorId => 0xeb49081d;
    public string Url { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatInvite" />
    ///</summary>
    public MyTelegram.Schema.IChatInvite ChatInvite { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
        ChatInvite.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
        ChatInvite = br.Deserialize<MyTelegram.Schema.IChatInvite>();
    }
}