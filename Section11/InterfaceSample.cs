using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    class InterfaceSample : IWebElement, IMouse
    {
        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            throw new NotImplementedException();
        }

        public void Click(ICoordinates where)
        {
            throw new NotImplementedException();
        }

        public void ContextClick(ICoordinates where)
        {
            throw new NotImplementedException();
        }

        public void DoubleClick(ICoordinates where)
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void MouseDown(ICoordinates where)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(ICoordinates where)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(ICoordinates where, int offsetX, int offsetY)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(ICoordinates where)
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
