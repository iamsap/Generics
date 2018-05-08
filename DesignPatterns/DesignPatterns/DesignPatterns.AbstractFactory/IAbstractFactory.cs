using System;

namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractFactory<out T> where T : IEntity
    {
        T CreateInstance();
    }
}
