using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AgentObjects;
using AxAgentObjects;

namespace ProyectoNuevoMatematica
{
    class CAgent
    {
        #region Atributes of the class
        ///<summary>
        ///Datos o variables miembro
        ///</summary>

        private AxAgent mMSAgent = new AxAgent();//un objeto del tipo mMSAgent 
        private string mName;
        private int mX, mY;
        private int mVoice;// la vos 
        private int mCadence;// velocidad de la vos se mantiene una unica velocidad 

        #endregion

        #region Propiedades
        ///<summary>
        ///Manejo de descriptores de acceso
        ///</summary>   

        public AxAgent MSAgente
        {
            get { return mMSAgent; }
            set { mMSAgent = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int X
        {
            get { return mX; }
            set { mX = value; }
        }

        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }

        public int Voice
        {
            get { return mVoice; }
            set { mVoice = value; }
        }

        public int Cadence
        {
            get { return mCadence; }
            set { mCadence = value; }
        }

        #endregion

        #region Builders of the Class
        ///<summary>
        /// Constructores
        ///</summary>

        // Constructor por defecto
        public CAgent()
        {

        }

        public CAgent(string Name, Form ObjForm, int xBegin, int yEnd)
        {
            mCadence = 100;
            mVoice = 200;
            mX = xBegin;
            mY = yEnd;
            mName = Name;
            mMSAgent.BeginInit();//con el objeto llamamos a la funcion inicializar 
            ObjForm.Controls.Add(mMSAgent);
            mMSAgent.EndInit();
            mMSAgent.Characters.Load(mName, mName + ".acs");//cargamos el personaje con el nombre y la extencion
            ChooseLanguage(true);//seleccionamos el lenguaje con el true el español y el false el ingles 
            mMSAgent.BringToFront();//enviamos al frente al agente y aparece alfrente del formulario
        }

        #endregion

        #region Methods
        ///<summary>
        ///Funciones miembro
        ///</summary>  

        public void ChooseLanguage(Boolean op)
        {
            if (op == true)
            {
                // Idioma Español
                mMSAgent.Characters[mName].LanguageID = 3082;//cargamos el id del lenguaje del agente 
            }
            else
            {
                // Idioma Inglés
                mMSAgent.Characters[mName].LanguageID = 0x409;//ingles
            }
        }

        public void ChooseVoice(int tone)
        {
            mVoice = tone;
        }

        public void setCadence(int Cadence)
        {
            mCadence = Cadence;
        }

        public void GoStartPosition(Form formulario)
        {
            mMSAgent.Characters[mName].MoveTo(100, 100, mCadence);
        }

        public void HideAgent()//mandamos al agente
        {
            StopAgent();
            mMSAgent.Characters[mName].Hide(null);
        }

        public void FireAgent()//despedimos al agente
        {
            StopAgent();
            mMSAgent.Characters[mName].Play("Wave");
        }

        public void StopAgent()
        {
            mMSAgent.Characters[mName].StopAll("Play");//evento del agente 
            mMSAgent.Characters[mName].StopAll("Speak");
            mMSAgent.Characters[mName].StopAll("Move");
        }

        public void ShowAgent(Form formulario)
        {
            StopAgent();
            mMSAgent.BringToFront();
            //agente.Characters[Name].MoveTo((short)(formulario.DesktopLocation.X + x), (short)(formulario.DesktopLocation.Y + y), Cadence);
            mMSAgent.Characters[mName].MoveTo(50, 50, mCadence);
            //agente.Characters[Name].MoveTo(50, 50, 0);
            mMSAgent.Characters[mName].Show(null);
        }

        public void IniciarBienvenida(Form ObjForm)
        {
            mMSAgent.Characters[mName].Balloon.Style = 3;
            mMSAgent.Characters[mName].Play("Greet");
            mMSAgent.Characters[mName].Play("Announce");
            //mMSAgent.Characters[mName].Speak("\\pit=" + Voice + "\\ Bievenido al Akinator", null);
            mMSAgent.Characters[mName].Speak("Bievenido.", null);
            mMSAgent.Characters[mName].Play("Blink");
            mMSAgent.Characters[mName].MoveTo(100, 300, mCadence);
            mMSAgent.Characters[mName].Play("GestureLeft");
            mMSAgent.Characters[mName].Speak("Para empezar aqui tienes tres opciones entre las cuales puedes escoger" +
                "Jugar, Aprender y Comprobar tus conocimientos mediante una evaluacion" +
                "Adelante, y diviertete mucho", null);
            mMSAgent.Characters[mName].Play("DoMagic1");
            //mMSAgent.Characters[mName].Play("DoMagic2");
            HideAgent();
        }

        public void LeerPregunta(Form ObjForm, Label lblPregunta, short x, short y)
        {
            StopAgent();
            mMSAgent.Characters[mName].Balloon.Style = 3;
            mX = x;
            mY = y;
            mMSAgent.Characters[mName].MoveTo((short)mX, (short)mY, mCadence);
            mMSAgent.Characters[mName].Play("GestureRight");
            mMSAgent.Characters[mName].Speak(lblPregunta.Text, null);
            mMSAgent.Characters[mName].Play("DoMagic1");
            mMSAgent.Characters[mName].Play("DoMagic2");
        }

        public void LeerTexto(Form ObjForm, string texto, short x, short y)
        {
            StopAgent();
            mMSAgent.Characters[mName].Balloon.Style = 3;
            mX = x;
            mY = y;
            mMSAgent.Characters[mName].MoveTo((short)mX, (short)mY, mCadence);
            mMSAgent.Characters[mName].Play("GestureRight");
            mMSAgent.Characters[mName].Speak(texto, null);
            mMSAgent.Characters[mName].Play("DoMagic1");
            mMSAgent.Characters[mName].Play("DoMagic2");
        }

        #endregion
    }
}
