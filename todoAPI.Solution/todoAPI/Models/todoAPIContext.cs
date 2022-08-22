using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace todoAPI.Models
{
  public class todoAPIContext : DbContext
  {
    public todoAPIContext(DbContextOptions<todoAPIContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<ToDo>()
          .HasData(
              new ToDo { ToDoId = 1, Name = "Waka-Waka", PP = 68, Category = "Personal", Description = "Walks your dog", Image = "~/img/waka-waka.png" },
              new ToDo { ToDoId = 2, Name = "Waashmo", PP = 2, Category = "Home", Description = "Does your laundry", Image = "~/img/waashmo.png" },
              new ToDo { ToDoId = 3, Name = "Irirs", PP = 67, Category = "Personal", Description = "Does your taxes", Image = "~/img/irirs.png" },
              new ToDo { ToDoId = 4, Name = "Munchakoopa", PP = 7, Category = "Food", Description = "Buys you groceries", Image = "~/img/munchakoopa.png" },
              new ToDo { ToDoId = 5, Name = "Monyay", PP = 70, Category = "School", Description = "Does your Epicodus homework", Image = "~/img/monyay.png" },
              new ToDo { ToDoId = 6, Name = "Swolium", PP = 89, Category = "Personal", Description = "Your own personal trainer", Image = "~/img/swolium.png" },
              new ToDo { ToDoId = 7, Name = "Cannowat", PP = 15, Category = "Home", Description = "Waters your indoor plants", Image = "~/img/cannowat.png" },
              new ToDo { ToDoId = 8, Name = "Snips", PP = 80, Category = "Personal", Description = "Cuts your hair", Image = "~/img/snips.png" },
              new ToDo { ToDoId = 9, Name = "Jiffyum", PP = 93, Category = "Car", Description = "Changes your oil", Image = "~/img/jiffyum.png" },
              new ToDo { ToDoId = 10, Name = "Arm and Leg", PP = 27, Category = "Home", Description = "Pays your rent", Image = "~/img/arm_and_leg.png" },
              new ToDo { ToDoId = 11, Name = "Suckuebus", PP = 53, Category = "Home", Description = "Vacuums your house", Image = "~/img/suckuebus.png" },
              new ToDo { ToDoId = 12, Name = "Waiterus", PP = 42, Category = "Car", Description = "Goes to the DMV", Image = "~/img/waiterus.png" },
              new ToDo { ToDoId = 13, Name = "Wedder", PP = 33, Category = "Personal", Description = "Plans the wedding", Image = "~/img/wedder.png" },
              new ToDo { ToDoId = 14, Name = "DinDin", PP = 48, Category = "Food", Description = "Preps all your meals", Image = "~/img/dindin.png" },
              new ToDo { ToDoId = 15, Name = "Booksi", PP = 61, Category = "Personal", Description = "Goes to the library", Image = "~/img/booksi.png" },
              new ToDo { ToDoId = 16, Name = "50 Bucks", PP = 57, Category = "Car", Description = "Fills your tank a little", Image = "~/img/50_bucks.png" },
              new ToDo { ToDoId = 17, Name = "Rodded", PP = 88, Category = "Personal", Description = "Forces you to watch Hotrod", Image = "~/img/rodded.png" },
              new ToDo { ToDoId = 18, Name = "Vamp", PP = 65, Category = "Health", Description = "Extracts and donates your blood", Image = "~/img/vamp.png" },
              new ToDo { ToDoId = 19, Name = "Momo", PP = 34, Category = "Home", Description = "Mows your lawn", Image = "~/img/momo.png" },
              new ToDo { ToDoId = 20, Name = "Plump Plumber", PP = 11, Category = "Home", Description = "Fixes your sink", Image = "~/img/plump_plumber.png" },
              new ToDo { ToDoId = 21, Name = "Medichu", PP = 100, Category = "Health", Description = "Meditates ... or just sleeps", Image = "~/img/medichu.png" },
              new ToDo { ToDoId = 22, Name = "Close Call", PP = 34, Category = "Health", Description = "Manditory colonoscopy: you must make a copy of your colons", Image = "~/img/close_call.png" },
              new ToDo { ToDoId = 23, Name = "Whiteboardpuff", PP = 15, Category = "School", Description = "Makes you do a technical interview", Image = "~/img/whiteboardpuff.png" },
              new ToDo { ToDoId = 24, Name = "Loanio", PP = 67, Category = "Personal", Description = "Checks your credit score - damages your credit", Image = "~/img/loanio.png" },
              new ToDo { ToDoId = 25, Name = "Smokey", PP = 90, Category = "Home", Description = "Replaces batteries in smoke detectors", Image = "~/img/smokey.png" },
              new ToDo { ToDoId = 26, Name = "*", PP = 76, Category = "Car", Description = "Washes your car with a dirty rag", Image = "~/img/*.png" },
              new ToDo { ToDoId = 27, Name = "*", PP = 51, Category = "Personal", Description = "Gets one free massage from you", Image = "~/img/*.png" },
              new ToDo { ToDoId = 28, Name = "Ghostgarper", PP = 0, Category = "Food", Description = "Makes you eat a ghost pepper", Image = "~/img/ghostgarper.png" },
              new ToDo { ToDoId = 29, Name = "Flipmonchan", PP = 0, Category = "Home", Description = "Flips your mattress for no reason", Image = "~/img/flipmonchan.png" },
              new ToDo { ToDoId = 30, Name = "Trashpinch", PP = 0, Category = "Home", Description = "Takes out your trash", Image = "~/img/trashpinch.png" },
              new ToDo { ToDoId = 31, Name = "Mailapod", PP = 0, Category = "Home", Description = "Gets your mail - shreds it", Image = "~/img/mailapod.png" },
              new ToDo { ToDoId = 32, Name = "Mr. Dirty", PP = 0, Category = "Home", Description = "Cleans your dishes without soap", Image = "~/img/mr_dirty.png" },
              new ToDo { ToDoId = 33, Name = "Cookietron", PP = 0, Category = "Food", Description = "Bakes cookies - burns them", Image = "~/img/cookietron.png" },
              new ToDo { ToDoId = 34, Name = "Carl's Dad", PP = 3, Category = "Personal", Description = "Plans Carl's funeral", Image = "~/img/carls_dad.png" },
              new ToDo { ToDoId = 35, Name = "*", PP = 0, Category = "School", Description = "Makes your README file - never credits you", Image = "~/img/*.png" },
              new ToDo { ToDoId = 36, Name = "*", PP = 0, Category = "School", Description = "Updates your resume with their name and contact info", Image = "~/img/*.png" },
              new ToDo { ToDoId = 37, Name = "Moprog", PP = 0, Category = "Home", Description = "Mops your floor with too much soap", Image = "~/img/moprog.png" },
              new ToDo { ToDoId = 38, Name = "You Died", PP = 0, Category = "Personal", Description = "You must speed run Darksouls", Image = "~/img/you_died.png" },
              new ToDo { ToDoId = 39, Name = "Scrubadubdub", PP = 0, Description = "Takes a bath - you no longer have a bath", Image = "~/img/scrubadubdub.png" },
              new ToDo { ToDoId = 40, Name = "Justa 'Lil Prick", PP = 0, Description = "Time to get your flu shot", Image = "~/img/justa_lil_prick.png" },
              new ToDo { ToDoId = 41, Name = "Remiu", PP = 0, Description = "Rings whenever you forget a semicolon", Image = "~/img/remiu.png" },
              new ToDo { ToDoId = 42, Name = "Clefridgy", PP = 0, Description = "Cleans out your fridge entirely", Image = "~/img/clefridgy.png" },
              new ToDo { ToDoId = 43, Name = "ChaCha-mon", PP = 0, Description = "Teaches you how to dance", Image = "~/img/chacha-mon.png" },
              new ToDo { ToDoId = 44, Name = "MoneyBanks", PP = 0, Description = "Invests in bitcoin and in your future", Image = "~/img/moneybanks.png" },
              new ToDo { ToDoId = 45, Name = "Santa's Helper", PP = 0, Description = "Eats your whole roll of Cookiedough as fast as he can", Image = "~/img/santas_helper.png" },
              new ToDo { ToDoId = 46, Name = "Grincheon", PP = 0, Description = "Solves world hunger; doesn't tell you how", Image = "~/img/grincheon.png" },
              new ToDo { ToDoId = 47, Name = "Wondusnot", PP = 0, Description = "Simply walks into Mordor", Image = "~/img/wondusnot.png" },
              new ToDo { ToDoId = 48, Name = "Marlout", PP = 0, Description = "Finds Nemo - doesn't tell you where", Image = "~/img/marlout.png" },
              new ToDo { ToDoId = 49, Name = "B-back 7000", PP = 0, Description = "Kills Sarah Connor - legally", Image = "~/img/b-back_7000.png" }
          );
    }

    public DbSet<ToDo> ToDos { get; set; }
  }
}