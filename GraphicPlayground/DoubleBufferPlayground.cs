﻿using SharpDX.DirectSound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistortionAnalyser
{
    public partial class DoubleBufferPlayground : Control
    {
        public IModelDrawer Model { get; set; }
        public int FPS { get; set; }
        public int Time { get; internal set; }
        public int Amount { get; internal set; }

        private DirectSound _directSound;

        private Stopwatch watch = new Stopwatch();

        public DoubleBufferPlayground()
        {
            InitializeComponent();
        }

        private void Playground_MouseClick(object sender, MouseEventArgs e)
        {
            if (theTimer.Enabled)
            {
                Host.AddMouseEvent(e);
            }
        }

        public void Load()
        {
            _directSound = new DirectSound();

            // Set Cooperative Level to PRIORITY (priority level can call the SetFormat and Compact methods)
            _directSound.SetCooperativeLevel(this.Handle, CooperativeLevel.Priority);

            // Create PrimarySoundBuffer
            var primaryBufferDesc = new SoundBufferDescription();
            primaryBufferDesc.Flags = BufferFlags.PrimaryBuffer;
            primaryBufferDesc.AlgorithmFor3D = Guid.Empty;

            var primarySoundBuffer = new PrimarySoundBuffer(_directSound, primaryBufferDesc);
            // Play the PrimarySound Buffer
            primarySoundBuffer.Play(0, PlayFlags.Looping);

            this.Host = new HostMediator(this, _directSound);

            Model.Setup(Width, Height, Amount, this.Host);

            this.BackColor = Color.Black;
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            watch.Start();

            //timer = new Timer();
            //timer.Interval = 1000 / 30;
            //timer.Tick += Timer_Tick;
            //timer.Start();

            theTimer = new Timer();
            theTimer.Interval = (1000 / FPS);
            theTimer.Tick += DrawModel;
            theTimer.Start();

            
        }

        private Timer theTimer = null;
        private long after;
        private DateTime StartTime = DateTime.Now;
        private HostMediator Host;
        private bool ShowStats = true;
        private TimeSpan GameTimer = new TimeSpan(0, 0, 0);

        private void DrawModel(object p1, object p2)
        {
            if (GameTimer.TotalSeconds > Time)
            {
                watch.Stop();
                theTimer.Stop();
                return;
            }

            theTimer.Enabled = false;

            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with Form1, and with
            // dimensions the same size as the drawing surface of Form1.
            using (myBuffer = currentContext.Allocate(this.CreateGraphics(),
               this.DisplayRectangle))
            {
                var g = myBuffer.Graphics;
                g.FillRectangle(new SolidBrush(Color.Black), 0, 0, this.Width, this.Height);
                var before = watch.ElapsedMilliseconds;
                var renderTime = before - after;
                after = watch.ElapsedMilliseconds;

                var renderStart = watch.ElapsedMilliseconds;

                Model.DrawOn(g, Host, (int)renderTime);

                GameTimer = GameTimer.Add(TimeSpan.FromMilliseconds(renderTime));
                Host.SetStatictic("Time", GameTimer.TotalSeconds);

                Host.SetStatictic("Model Update", watch.ElapsedMilliseconds - renderStart);

                var nextInterval = (int)((1000 / FPS) - renderTime);
                nextInterval = nextInterval < 1 ? 1 : nextInterval;

                Host.SetStatictic("Elapsed", renderTime);
                Host.SetStatictic("Next Interval", nextInterval);
                Host.SetStatictic("Watch", watch.ElapsedMilliseconds);

                if (ShowStats)
                { 
                    var yOffset = 0;
                    foreach (var key in Host.Stats.Keys)
                    {
                        g.DrawString(key, this.Font, new SolidBrush(Color.White), 100, 100 + yOffset);
                        g.DrawString(Host.Stats[key], this.Font, new SolidBrush(Color.White), 250, 100 + yOffset);
                        yOffset += 20;
                    }
                }
                myBuffer.Render();

                theTimer.Interval = nextInterval;
                theTimer.Enabled = true;
            }           

        }
             
        private void Playground_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                theTimer.Enabled = !theTimer.Enabled;
                if (theTimer.Enabled)
                {
                    watch.Start();
                }
                else
                {
                    watch.Stop();
                }
            }

            if (e.KeyChar == (char)Keys.S)
            {
                ShowStats = !ShowStats;
            }
        }

    }
}
