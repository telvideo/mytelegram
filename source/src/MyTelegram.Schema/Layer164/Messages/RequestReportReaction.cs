﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Report a <a href="https://corefork.telegram.org/api/reactions">message reaction</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 USER_ID_INVALID The provided user ID is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.reportReaction" />
///</summary>
[TlObject(0x3f64c076)]
public sealed class RequestReportReaction : IRequest<IBool>
{
    public uint ConstructorId => 0x3f64c076;
    ///<summary>
    /// Peer where the message was sent
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// Peer that sent the reaction
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer ReactionPeer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Id);
        writer.Write(ReactionPeer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.ReadInt32();
        ReactionPeer = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}