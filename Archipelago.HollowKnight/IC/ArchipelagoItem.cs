﻿using ItemChanger;
using ItemChanger.Tags;
using ItemChanger.UIDefs;

namespace Archipelago.HollowKnight.IC
{
    public class ArchipelagoItem : AbstractItem
    {
        public ArchipelagoItem(string name)
        {
            this.name = name;
            UIDef = new ArchipelagoUIDef(new MsgUIDef
            {
                name = new BoxedString(this.name),
                shopDesc = new BoxedString("This looks important, assuming beating the game is important to you."),
                sprite = new BoxedSprite(Archipelago.SmallSprite)
            });

            InteropTag tag = AddTag<InteropTag>();
            tag.Message = "RecentItems";
            tag.Properties["DisplayMessage"] = $"{this.name}\nsent to the multiworld.";
        }

        public override void GiveImmediate(GiveInfo info)
        {

        }
    }
}