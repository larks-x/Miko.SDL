﻿// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace SDL;

partial struct SDL_GPUMultisampleState
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SDL_GPUMultisampleState"/> structure.
    /// </summary>
    public SDL_GPUMultisampleState(SDL_GPUSampleCount sampleCount, uint sampleMask = uint.MaxValue)
    {
        this.sample_count = sampleCount;
        this.sample_mask = sampleMask;
    }
}
