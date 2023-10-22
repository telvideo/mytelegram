﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// See <a href="https://corefork.telegram.org/method/stories.getAllStories" />
///</summary>
[TlObject(0xeeb0d625)]
public sealed class RequestGetAllStories : IRequest<MyTelegram.Schema.Stories.IAllStories>
{
    public uint ConstructorId => 0xeeb0d625;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Next { get; set; }
    public bool Hidden { get; set; }
    public string? State { get; set; }

    public void ComputeFlag()
    {
        if (Next) { Flags[1] = true; }
        if (Hidden) { Flags[2] = true; }
        if (State != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(State); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Next = true; }
        if (Flags[2]) { Hidden = true; }
        if (Flags[0]) { State = reader.ReadString(); }
    }
}