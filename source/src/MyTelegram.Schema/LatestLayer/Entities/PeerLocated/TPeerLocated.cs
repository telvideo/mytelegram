﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Peer geolocated nearby
/// See <a href="https://corefork.telegram.org/constructor/peerLocated" />
///</summary>
[TlObject(0xca461b5d)]
public sealed class TPeerLocated : IPeerLocated
{
    public uint ConstructorId => 0xca461b5d;
    ///<summary>
    /// Peer
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// Validity period of current data
    ///</summary>
    public int Expires { get; set; }

    ///<summary>
    /// Distance from the peer in meters
    ///</summary>
    public int Distance { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Expires);
        writer.Write(Distance);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        Expires = reader.ReadInt32();
        Distance = reader.ReadInt32();
    }
}