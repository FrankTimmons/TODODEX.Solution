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
              new ToDo { ToDoId = 1, Name = "Waka-Waka", PP = 68, Category = "Personal", Description = "Walks your dog", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011680146673123339/wakawaka.png" },
              new ToDo { ToDoId = 2, Name = "Waashmo", PP = 2, Category = "Home", Description = "Does your laundry", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011687033116299284/waashmo.png" },
              new ToDo { ToDoId = 3, Name = "Irirs", PP = 67, Category = "Personal", Description = "Does your taxes", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011386221441847326/irirs.png" },
              new ToDo { ToDoId = 4, Name = "Munchakoopa", PP = 7, Category = "Food", Description = "Buys you groceries", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011342412297281606/munchakoopa.png" },
              new ToDo { ToDoId = 5, Name = "Monyay", PP = 70, Category = "School", Description = "Does your Epicodus homework", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011344877369425930/monyay.png" },
              new ToDo { ToDoId = 6, Name = "Swolium", PP = 89, Category = "Personal", Description = "Your own personal trainer", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011682719232704632/swolium.png" },
              new ToDo { ToDoId = 7, Name = "Cannowat", PP = 15, Category = "Home", Description = "Waters your indoor plants", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011688286126870598/cannowat.png" },
              new ToDo { ToDoId = 8, Name = "Snips", PP = 80, Category = "Personal", Description = "Cuts your hair", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011347425161654292/snips.png" },
              new ToDo { ToDoId = 9, Name = "Jiffyum", PP = 93, Category = "Car", Description = "Changes your oil", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011368404504031342/jiffyum.png" },
              new ToDo { ToDoId = 10, Name = "Arm and Leg", PP = 27, Category = "Home", Description = "Pays your rent", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011387943673397318/arm_and_leg.png" },
              new ToDo { ToDoId = 11, Name = "Suckuebus", PP = 53, Category = "Home", Description = "Vacuums your house", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011348731750252655/Suckuebus.png" },
              new ToDo { ToDoId = 12, Name = "Waiterus", PP = 42, Category = "Car", Description = "Goes to the DMV", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011689057723613305/waiterus.png" },
              new ToDo { ToDoId = 13, Name = "Wedder", PP = 33, Category = "Personal", Description = "Plans the wedding", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011722626709860442/wedder.png" },
              new ToDo { ToDoId = 14, Name = "DinDin", PP = 48, Category = "Food", Description = "Preps all your meals", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011670067211153439/DinDin.png" },
              new ToDo { ToDoId = 15, Name = "Booksi", PP = 61, Category = "Personal", Description = "Goes to the library", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686587882549341/Booksi.png" },
              new ToDo { ToDoId = 16, Name = "50 Bucks", PP = 57, Category = "Car", Description = "Fills your tank a little", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011340622675845281/50_bucks.png" },
              new ToDo { ToDoId = 17, Name = "Rodded", PP = 88, Category = "Personal", Description = "Forces you to watch Hotrod", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011359277492998294/rodded.png" },
              new ToDo { ToDoId = 18, Name = "Vamp", PP = 65, Category = "Health", Description = "Extracts and donates your blood", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011357411883364512/vamps.png" },
              new ToDo { ToDoId = 19, Name = "Momo", PP = 34, Category = "Home", Description = "Mows your lawn", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686667708551189/Momo.png" },
              new ToDo { ToDoId = 20, Name = "Plump Plumber", PP = 11, Category = "Home", Description = "Fixes your sink", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011687294954110986/PlumpPlumber.png" },
              new ToDo { ToDoId = 21, Name = "Medichu", PP = 100, Category = "Health", Description = "Meditates ... or just sleeps", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011420092384428133/medichu.png" },
              new ToDo { ToDoId = 22, Name = "Close Call", PP = 34, Category = "Health", Description = "Manditory colonoscopy: you must make a copy of your colons", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011362297127649351/CloseCall.png" },
              new ToDo { ToDoId = 23, Name = "Whiteboardpuff", PP = 15, Category = "School", Description = "Makes you do a technical interview", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686543003504750/WhiteBoardPuff.png" },
              new ToDo { ToDoId = 24, Name = "Loanio", PP = 67, Category = "Personal", Description = "Checks your credit score - damages your credit", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686725837406280/Loanio.png" },
              new ToDo { ToDoId = 25, Name = "Smokey", PP = 90, Category = "Home", Description = "Replaces batteries in smoke detectors", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011393369731248220/smokey.png" },
              new ToDo { ToDoId = 26, Name = "WashyCar", PP = 76, Category = "Car", Description = "Washes your car with a dirty rag", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011349207539515453/Carwash.png" },
              new ToDo { ToDoId = 27, Name = "Hamassage", PP = 51, Category = "Personal", Description = "Gives you one free massage", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011716974822305842/hamassage.png" },
              new ToDo { ToDoId = 28, Name = "Ghostgarper", PP = 0, Category = "Food", Description = "Makes you eat a ghost pepper", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011390601897455686/ghostgarper.png" },
              new ToDo { ToDoId = 29, Name = "Flipmonchan", PP = 0, Category = "Home", Description = "Flips your mattress for no reason", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686784633143346/FlipMonChan.png" },
              new ToDo { ToDoId = 30, Name = "Trashpinch", PP = 0, Category = "Home", Description = "Takes out your trash", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011684166254993498/trashpinch.png" },
              new ToDo { ToDoId = 31, Name = "Mailapod", PP = 0, Category = "Home", Description = "Gets your mail - shreds it", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011682850715750460/mailapod.png" },
              new ToDo { ToDoId = 32, Name = "Mr. Dirty", PP = 0, Category = "Home", Description = "Cleans your dishes without soap", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011395918093893722/MR_Dirty.png" },
              new ToDo { ToDoId = 33, Name = "Cookietron", PP = 0, Category = "Food", Description = "Bakes cookies - burns them", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011687059389427732/CookieTron.png" },
              new ToDo { ToDoId = 34, Name = "Carl's Dad", PP = 3, Category = "Personal", Description = "Plans Carl's funeral", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011687190692106360/CarlsDad.png" },
              new ToDo { ToDoId = 35, Name = "Seekzatenshun", PP = 0, Category = "School", Description = "Makes your README file - never credits you", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011718304840294481/SeekZaTenShun.png" },
              new ToDo { ToDoId = 36, Name = "Jobbofind", PP = 0, Category = "School", Description = "Updates your resume with their name and contact info", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011720274082791494/resumoocher.png" },
              new ToDo { ToDoId = 37, Name = "Moprog", PP = 0, Category = "Home", Description = "Mops your floor with too much soap", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686475169026048/Moprog.png" },
              new ToDo { ToDoId = 38, Name = "You Died", PP = 0, Category = "Personal", Description = "You must speed run Darksouls", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011415353122889879/you_died.png" },
              new ToDo { ToDoId = 39, Name = "Scrubadubdub", PP = 0, Description = "Takes a bath - you no longer have a bath", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011417800079847494/scrubadubdub.png" },
              new ToDo { ToDoId = 40, Name = "Justa 'Lil Prick", PP = 0, Description = "Time to get your flu shot", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686915407360000/JustALittlePrick.png" },
              new ToDo { ToDoId = 41, Name = "Remiu", PP = 0, Description = "Rings whenever you forget a semicolon", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686999729639585/Remiu.png" },
              new ToDo { ToDoId = 42, Name = "Clefridgy", PP = 0, Description = "Cleans out your fridge entirely", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011687090943168552/Clefridgy.png" },
              new ToDo { ToDoId = 43, Name = "ChaCha-mon", PP = 0, Description = "Teaches you how to dance", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011417750452830228/unknown.png" },
              new ToDo { ToDoId = 44, Name = "MoneyBanks", PP = 0, Description = "Invests in bitcoin and in your future", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011401474997223455/unknown.png" },
              new ToDo { ToDoId = 45, Name = "Santa's Helper", PP = 0, Description = "Eats your whole roll of Cookiedough as fast as he can", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011686842841698314/SantasHelper.png" },
              new ToDo { ToDoId = 46, Name = "Grincheon", PP = 0, Description = "Solves world hunger; doesn't tell you how", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011419920761892904/unknown.png" },
              new ToDo { ToDoId = 47, Name = "Wondusnot", PP = 0, Description = "Simply walks into Mordor", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011685949102628905/wondusnot.png" },
              new ToDo { ToDoId = 48, Name = "Marlout", PP = 0, Description = "Finds Nemo - doesn't tell you where", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011361910991630467/Find_nemo.png" },
              new ToDo { ToDoId = 49, Name = "B-back 7000", PP = 0, Description = "Kills Sarah Connor - legally", Image = "https://cdn.discordapp.com/attachments/1011292802468032512/1011680839869927575/unknown.png" }
          );
    }

    public DbSet<ToDo> ToDos { get; set; }
  }
}