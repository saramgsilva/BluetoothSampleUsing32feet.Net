using System;
using System.ComponentModel;

namespace Bluetooth.Services
{
    /// <summary>
    /// Define the receiver Bluetooth service interface.
    /// </summary>
    public interface IReceiverBluetoothService
    {
        /// <summary>
        /// Gets a value indicating whether was started.
        /// </summary>
        /// <value>
        /// The was started.
        /// </value>
        bool WasStarted { get; }
        
        /// <summary>
        /// Starts the listening from Senders.
        /// </summary>
        /// <param name="reportAction">
        /// The report Action.
        /// </param>
        void Start(Action<string> reportAction);

        /// <summary>
        /// Stops the listening from Senders.
        /// </summary>
        void Stop();

        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
    }
}