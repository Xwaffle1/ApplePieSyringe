﻿using MonoMod;
using System;
using System.IO;
using Temtem.Players;

namespace Temtem.Players
{
    class patch_PlayerController
    { 
        public extern void orig_Update();

        public void Update()
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\PlayerLocation.txt", false))
            {
                sw.WriteLine(string.Concat(new object[]
                {
                    LocalPlayerAvatar.nkqrjhelndm.jilhdqdhqem.ccrcgoerhog.x,
                    ", ",
                    LocalPlayerAvatar.nkqrjhelndm.jilhdqdhqem.ccrcgoerhog.y,
                    ", ",
                    LocalPlayerAvatar.nkqrjhelndm.jilhdqdhqem.ccrcgoerhog.z
                }));
            }
            orig_Update();

        }
    }
}
