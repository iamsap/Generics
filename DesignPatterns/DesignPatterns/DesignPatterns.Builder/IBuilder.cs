using System;

namespace DesignPatterns.Builder
{
    public interface IBuilder<in T, out TOutput>
    {
        TOutput Construct(T source);
    }
}
