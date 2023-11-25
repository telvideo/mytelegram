﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Channel/supergroup username was changed
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionChangeUsername" />
///</summary>
[TlObject(0x6a4afc38)]
public sealed class TChannelAdminLogEventActionChangeUsername : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x6a4afc38;
    ///<summary>
    /// Old username
    ///</summary>
    public string PrevValue { get; set; }

    ///<summary>
    /// New username
    ///</summary>
    public string NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(PrevValue);
        writer.Write(NewValue);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        PrevValue = reader.ReadString();
        NewValue = reader.ReadString();
    }
}