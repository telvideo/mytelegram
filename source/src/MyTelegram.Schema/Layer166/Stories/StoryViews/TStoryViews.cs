﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// Reaction and view counters for a list of <a href="https://corefork.telegram.org/api/stories">stories</a>
/// See <a href="https://corefork.telegram.org/constructor/stories.storyViews" />
///</summary>
[TlObject(0xde9eed1d)]
public sealed class TStoryViews : IStoryViews
{
    public uint ConstructorId => 0xde9eed1d;
    ///<summary>
    /// View date and reaction information of multiple stories
    ///</summary>
    public TVector<MyTelegram.Schema.IStoryViews> Views { get; set; }

    ///<summary>
    /// Mentioned users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Views);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Views = reader.Read<TVector<MyTelegram.Schema.IStoryViews>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}