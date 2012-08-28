namespace ISimpleIOCContainter
{
    using System;
    //using System.Configuration;
    //using System.Xml.XmlNode;

    public interface ISimpleIOCContainer
    {
        void Register<TContract, TImplementation> ();
        TContract Resolve<TContract>();
    }
}
