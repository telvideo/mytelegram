﻿// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/ReactionNotificationsFrom" />
///</summary>
[JsonDerivedType(typeof(TReactionNotificationsFromContacts), nameof(TReactionNotificationsFromContacts))]
[JsonDerivedType(typeof(TReactionNotificationsFromAll), nameof(TReactionNotificationsFromAll))]
public interface IReactionNotificationsFrom : IObject
{

}