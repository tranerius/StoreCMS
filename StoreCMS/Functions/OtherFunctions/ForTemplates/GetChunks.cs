﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Treynessen.Database.Context;
using Treynessen.Database.Entities;

namespace Treynessen.Functions
{
    public static partial class OtherFunctions
    {
        public static LinkedList<Chunk> GetChunks(CMSDatabase db, string source, string currentChunkName = null)
        {
            LinkedList<Chunk> chunks = new LinkedList<Chunk>();
            int pointer = 0;
            while (pointer != -1)
            {
                pointer = GetNextChunk(pointer, source, out string chunkName);
                if (!string.IsNullOrEmpty(chunkName) && !chunkName.Equals(currentChunkName, StringComparison.InvariantCulture))
                {
                    Chunk chunk = db.Chunks.FirstOrDefaultAsync(tc => tc.Name.Equals(chunkName, StringComparison.InvariantCulture)).Result;
                    if (chunk != null)
                    {
                        db.Entry(chunk).State = EntityState.Detached;
                        chunks.AddLast(chunk);
                    }
                }
            }
            return chunks;
        }
    }
}