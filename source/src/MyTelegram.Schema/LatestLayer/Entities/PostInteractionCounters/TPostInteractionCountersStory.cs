﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/postInteractionCountersStory" />
///</summary>
[TlObject(0x8a480e27)]
public sealed class TPostInteractionCountersStory : IPostInteractionCounters
{
    public uint ConstructorId => 0x8a480e27;
    ///<summary>
    /// &nbsp;
    ///</summary>
    public int StoryId { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Views { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Forwards { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Reactions { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(StoryId);
        writer.Write(Views);
        writer.Write(Forwards);
        writer.Write(Reactions);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        StoryId = reader.ReadInt32();
        Views = reader.ReadInt32();
        Forwards = reader.ReadInt32();
        Reactions = reader.ReadInt32();
    }
}