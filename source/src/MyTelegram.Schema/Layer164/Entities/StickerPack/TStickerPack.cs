﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A stickerpack is a group of stickers associated to the same emoji.<br>
/// It is <strong>not</strong> a sticker pack the way it is usually intended, you may be looking for a <a href="https://corefork.telegram.org/type/StickerSet">StickerSet</a>.
/// See <a href="https://corefork.telegram.org/constructor/stickerPack" />
///</summary>
[TlObject(0x12b299d4)]
public sealed class TStickerPack : IStickerPack
{
    public uint ConstructorId => 0x12b299d4;
    ///<summary>
    /// Emoji
    ///</summary>
    public string Emoticon { get; set; }

    ///<summary>
    /// Stickers
    ///</summary>
    public TVector<long> Documents { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Emoticon);
        writer.Write(Documents);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Emoticon = reader.ReadString();
        Documents = reader.Read<TVector<long>>();
    }
}