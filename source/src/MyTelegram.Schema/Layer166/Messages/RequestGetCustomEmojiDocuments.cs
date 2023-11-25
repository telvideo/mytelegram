﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Fetch <a href="https://corefork.telegram.org/api/custom-emoji">custom emoji stickers »</a>.Returns a list of <a href="https://corefork.telegram.org/constructor/document">documents</a> with the animated custom emoji in TGS format, and a <a href="https://corefork.telegram.org/constructor/documentAttributeCustomEmoji">documentAttributeCustomEmoji</a> attribute with the original emoji and info about the emoji stickerset this custom emoji belongs to.
/// See <a href="https://corefork.telegram.org/method/messages.getCustomEmojiDocuments" />
///</summary>
[TlObject(0xd9ab0f54)]
public sealed class RequestGetCustomEmojiDocuments : IRequest<TVector<MyTelegram.Schema.IDocument>>
{
    public uint ConstructorId => 0xd9ab0f54;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/custom-emoji">Custom emoji</a> IDs from a <a href="https://corefork.telegram.org/constructor/messageEntityCustomEmoji">messageEntityCustomEmoji</a>.
    ///</summary>
    public TVector<long> DocumentId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(DocumentId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        DocumentId = reader.Read<TVector<long>>();
    }
}