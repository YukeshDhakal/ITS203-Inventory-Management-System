using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmartInventorySystem
{
    /// <summary>
    /// Handles all file-based data persistence using JSON
    /// Demonstrates Exception Handling with try-catch blocks
    /// </summary>
    public static class DataManager
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.json");

        // Custom converter to handle DateTime format
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Saves the inventory list to JSON file
        /// </summary>
        public static void SaveData(List<PerishableItem> items)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(items, _options);
                File.WriteAllText(FilePath, jsonString);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception($"Access denied while saving: {ex.Message}");
            }
            catch (IOException ex)
            {
                throw new Exception($"Disk error while saving: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error while saving: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads the inventory list from JSON file
        /// </summary>
        public static List<PerishableItem> LoadData()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    // Create empty list if file doesn't exist
                    return new List<PerishableItem>();
                }

                string jsonString = File.ReadAllText(FilePath);
                var items = JsonSerializer.Deserialize<List<PerishableItem>>(jsonString, _options);
                return items ?? new List<PerishableItem>();
            }
            catch (JsonException ex)
            {
                // Handle corrupted JSON file gracefully
                System.Windows.Forms.MessageBox.Show(
                    $"Inventory file appears corrupted. A new file will be created.\nError: {ex.Message}",
                    "Data Load Warning",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return new List<PerishableItem>();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error loading data: {ex.Message}\nStarting with empty inventory.",
                    "Load Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return new List<PerishableItem>();
            }
        }

        /// <summary>
        /// Checks if data file exists
        /// </summary>
        public static bool DataFileExists()
        {
            return File.Exists(FilePath);
        }
    }
}