using System.Collections.Generic;
using System.Threading.Tasks;
using Bluetooth.Model;

namespace Bluetooth.Services
{
    /// <summary>
    /// Define the sender Bluetooth service interface.
    /// </summary>
    public interface ISenderBluetoothService
    {
        /// <summary>
        /// Gets the devices.
        /// </summary>
        /// <returns>The list of the devices.</returns>
        Task<IList<Device>> GetDevices();

        /// <summary>
        /// Sends the data to the Receiver.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="content">The content.</param>
        /// <returns>If was sent or not.</returns>
        Task<bool> Send(Device device, string content);
    }
}