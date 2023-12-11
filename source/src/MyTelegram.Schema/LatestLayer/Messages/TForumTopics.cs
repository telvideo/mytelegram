﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Contains information about multiple <a href="https://corefork.telegram.org/api/forum#forum-topics">forum topics</a>
/// See <a href="https://corefork.telegram.org/constructor/messages.forumTopics" />
///</summary>
[TlObject(0x367617d3)]
public sealed class TForumTopics : IForumTopics
{
    public uint ConstructorId => 0x367617d3;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the returned topics are ordered by creation date; if set, pagination by <code>next_offset</code> should use <a href="https://corefork.telegram.org/constructor/forumTopic">forumTopic</a>.<code>date</code>; otherwise topics are ordered by the last message date, so paginate by the <code>date</code> of the <a href="https://corefork.telegram.org/type/Message">message</a> referenced by <a href="https://corefork.telegram.org/constructor/forumTopic">forumTopic</a>.<code>top_message</code>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool OrderByCreateDate { get; set; }

    ///<summary>
    /// Total number of topics matching query; may be less than the topics contained in <code>topics</code>, in which case <a href="https://corefork.telegram.org/api/offsets">pagination</a> is required.
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// Forum topics
    ///</summary>
    public TVector<MyTelegram.Schema.IForumTopic> Topics { get; set; }

    ///<summary>
    /// Related messages (contains the messages mentioned by <a href="https://corefork.telegram.org/constructor/forumTopic">forumTopic</a>.<code>top_message</code>).
    ///</summary>
    public TVector<MyTelegram.Schema.IMessage> Messages { get; set; }

    ///<summary>
    /// Related chats
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Related users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/updates">Event count after generation</a>
    ///</summary>
    public int Pts { get; set; }

    public void ComputeFlag()
    {
        if (OrderByCreateDate) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Count);
        writer.Write(Topics);
        writer.Write(Messages);
        writer.Write(Chats);
        writer.Write(Users);
        writer.Write(Pts);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { OrderByCreateDate = true; }
        Count = reader.ReadInt32();
        Topics = reader.Read<TVector<MyTelegram.Schema.IForumTopic>>();
        Messages = reader.Read<TVector<MyTelegram.Schema.IMessage>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
        Pts = reader.ReadInt32();
    }
}