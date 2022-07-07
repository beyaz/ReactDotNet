﻿using System;
using System.Linq;

namespace ReactDotNet.Html5.PrimeReact
{
    

    public enum ButtonPositionType
    {
        top, bottom, left, right
    }

    public class Button : ElementBase
    {
        public Button()
        {
            
        }

        public Button(params ElementModifier[] modifiers) : base(modifiers)
        {
        }



        /// <summary>
        ///     Text of the button.
        /// </summary>
        [React]
        public string label { get; set; }

        [React]
        public string icon { get; set; }

        /// <summary>
        /// Position of the icon, valid values are "left", "right", "top" and "bottom".
        /// </summary>
        [React]
        public ButtonPositionType? iconPos { get; set; }

        /// <summary>
        ///Display loading icon of the button
        /// </summary>
        [React]
        public bool? loading { get; set; }

        [React]
        public bool? disabled { get; set; }
        

        /// <summary>
        /// Name of the loading icon or JSX.Element for loading icon.
        /// </summary>
        [React]
        public string loadingIcon { get; set; }



      
        
        [React]
        public string badge { get; set; }

        [React]
        public string badgeClassName { get; set; }

        [React]
        public bool? autoFocus { get; set; }

    }
}