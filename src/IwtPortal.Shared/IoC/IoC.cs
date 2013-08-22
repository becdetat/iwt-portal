using Autofac;

namespace IwtPortal.Shared.IoC
{
    public static class IoC
    {
        public static IContainer Container { get; private set; }

        public static void SetContainer(IContainer container)
        {
            Container = container;
        }
    }
}