﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/messages.quickReplies" />
///</summary>
[TlObject(0xc68d6695)]
public sealed class TQuickReplies : IQuickReplies
{
    public uint ConstructorId => 0xc68d6695;
    public TVector<MyTelegram.Schema.IQuickReply> QuickReplies { get; set; }
    public TVector<MyTelegram.Schema.IMessage> Messages { get; set; }
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(QuickReplies);
        writer.Write(Messages);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        QuickReplies = reader.Read<TVector<MyTelegram.Schema.IQuickReply>>();
        Messages = reader.Read<TVector<MyTelegram.Schema.IMessage>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}