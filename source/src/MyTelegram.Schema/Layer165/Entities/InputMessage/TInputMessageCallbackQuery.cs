﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Used by bots for fetching information about the message that originated a callback query
/// See <a href="https://corefork.telegram.org/constructor/inputMessageCallbackQuery" />
///</summary>
[TlObject(0xacfa1a7e)]
public sealed class TInputMessageCallbackQuery : IInputMessage
{
    public uint ConstructorId => 0xacfa1a7e;
    ///<summary>
    /// Message ID
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// Callback query ID
    ///</summary>
    public long QueryId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(QueryId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt32();
        QueryId = reader.ReadInt64();
    }
}