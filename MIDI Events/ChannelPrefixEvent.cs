﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDIModificationFramework.MIDI_Events
{
    public class ChannelPrefixEvent : MIDIEvent
    {
        public byte Channel { get; set; }
        public ChannelPrefixEvent(uint delta, byte channel) : base(delta)
        {
            Channel = channel;
        }

        public override byte[] GetData()
        {
            return new byte[] { 0xFF, 0x20, 0x01, Channel };
        }
    }
}