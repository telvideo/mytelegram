﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Indicates an already sent game
/// See <a href="https://corefork.telegram.org/constructor/game" />
///</summary>
[TlObject(0xbdf9653b)]
public sealed class TGame : IGame
{
    public uint ConstructorId => 0xbdf9653b;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// ID of the game
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// Access hash of the game
    ///</summary>
    public long AccessHash { get; set; }

    ///<summary>
    /// Short name for the game
    ///</summary>
    public string ShortName { get; set; }

    ///<summary>
    /// Title of the game
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    /// Game description
    ///</summary>
    public string Description { get; set; }

    ///<summary>
    /// Game preview
    /// See <a href="https://corefork.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto Photo { get; set; }

    ///<summary>
    /// Optional attached document
    /// See <a href="https://corefork.telegram.org/type/Document" />
    ///</summary>
    public MyTelegram.Schema.IDocument? Document { get; set; }

    public void ComputeFlag()
    {
        if (Document != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(AccessHash);
        writer.Write(ShortName);
        writer.Write(Title);
        writer.Write(Description);
        writer.Write(Photo);
        if (Flags[0]) { writer.Write(Document); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Id = reader.ReadInt64();
        AccessHash = reader.ReadInt64();
        ShortName = reader.ReadString();
        Title = reader.ReadString();
        Description = reader.ReadString();
        Photo = reader.Read<MyTelegram.Schema.IPhoto>();
        if (Flags[0]) { Document = reader.Read<MyTelegram.Schema.IDocument>(); }
    }
}