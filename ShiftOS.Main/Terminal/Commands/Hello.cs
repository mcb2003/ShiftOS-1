﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class Hello : TerminalCommand
    {
        public override string Name { get; } = "Hello";
        public override string Summary { get; } = "Just an example command.";
        public override string Usage { get; } = "Hello <NAME>.";
        public override bool Unlocked { get; set; } = false;

        public override async void Run(params string[] parameters)
        {
            string name = string.Join(" ", parameters);
            WriteLine($"Oh, hello, {name}.", Color.Red);
            string age = await Input("Hey, What's your age?");
            WriteLine($"Ok, so your name is {name} and your age {age}.");
        }
    }
}
