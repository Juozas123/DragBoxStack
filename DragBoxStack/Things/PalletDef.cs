using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragBoxStack.Things
{
    public class PalletDef
    {
        public event EventHandler DimensionsChanged;

        private float width;
        public float Width
        {
            get => width;
            set => width = value;
        }

        private float length;
        public float Length
        {
            get => length;
            set => length = value;
        }

        private float height;
        public float Height
        {
            get => height;
            set => height = value;
        }

        public void UpdateDimensions(float width, float length, float height)
        {
            var fireChangedEvent = (Width != width) || (Length != length) || (Height != height);

            this.Width = width;
            this.Length = length;
            this.Height = height;

            if (fireChangedEvent)
                DimensionsChanged?.Invoke(this, new EventArgs());

        }

        public PalletDef(float width = 0.0F, float length = 0.0F, float height = 0.0F)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
        }
    }
}
