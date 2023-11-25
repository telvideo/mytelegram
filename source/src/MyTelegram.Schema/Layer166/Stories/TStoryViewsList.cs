﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// Reaction and view counters for a <a href="https://corefork.telegram.org/api/stories">story</a>
/// See <a href="https://corefork.telegram.org/constructor/stories.storyViewsList" />
///</summary>
[TlObject(0x46e9b9ec)]
public sealed class TStoryViewsList : IStoryViewsList
{
    public uint ConstructorId => 0x46e9b9ec;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Total number of results that can be fetched
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int ReactionsCount { get; set; }

    ///<summary>
    /// Story view date and reaction information
    ///</summary>
    public TVector<MyTelegram.Schema.IStoryView> Views { get; set; }

    ///<summary>
    /// Mentioned users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    ///<summary>
    /// Offset for pagination
    ///</summary>
    public string? NextOffset { get; set; }

    public void ComputeFlag()
    {
        if (NextOffset != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Count);
        writer.Write(ReactionsCount);
        writer.Write(Views);
        writer.Write(Users);
        if (Flags[0]) { writer.Write(NextOffset); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Count = reader.ReadInt32();
        ReactionsCount = reader.ReadInt32();
        Views = reader.Read<TVector<MyTelegram.Schema.IStoryView>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
        if (Flags[0]) { NextOffset = reader.ReadString(); }
    }
}