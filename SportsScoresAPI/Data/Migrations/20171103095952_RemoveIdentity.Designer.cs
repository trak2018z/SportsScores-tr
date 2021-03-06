﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SportsScoresAPI.Data;
using SportsScoresAPI.Models;
using System;

namespace SportsScoresAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171103095952_RemoveIdentity")]
    partial class RemoveIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.CompetitionEntity", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("NationalityId");

                    b.Property<string>("Season");

                    b.HasKey("CompetitionId");

                    b.HasIndex("NationalityId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.GameEntity", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AwayTeamGoals");

                    b.Property<int>("AwayTeamId");

                    b.Property<int>("CompetitionId");

                    b.Property<int?>("HalfAwayTeamGoals");

                    b.Property<int?>("HalfHomeTeamGoals");

                    b.Property<int?>("HomeTeamGoals");

                    b.Property<int>("HomeTeamId");

                    b.Property<DateTime>("MatchDate");

                    b.Property<int>("MatchDay");

                    b.Property<int>("Status");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.GameEventEntity", b =>
                {
                    b.Property<int>("GameEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventType");

                    b.Property<int>("GameId");

                    b.Property<TimeSpan>("OccurenceTime");

                    b.Property<int>("PlayerId");

                    b.Property<int>("TeamId");

                    b.HasKey("GameEventId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("GameEvents");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.GameSquadAssignmentEntity", b =>
                {
                    b.Property<int>("GameSquadAssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GameId");

                    b.Property<int>("PlayerId");

                    b.Property<int>("TeamId");

                    b.Property<TimeSpan>("TimeIn");

                    b.Property<TimeSpan?>("TimeOut");

                    b.HasKey("GameSquadAssignmentId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("GameSquadAssignments");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.NationalityEntity", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlagURL");

                    b.Property<string>("Name");

                    b.Property<string>("ShortName");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.PlayerEntity", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MarketValue");

                    b.Property<int>("NationalityId");

                    b.Property<int>("PlayerPositionId");

                    b.HasKey("PlayerId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("PlayerPositionId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.PlayerPositionEntity", b =>
                {
                    b.Property<int>("PlayerPositionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("PlayerPositionId");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.PlayerToTeamAssignmentEntity", b =>
                {
                    b.Property<int>("PlayerAssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("EndDate");

                    b.Property<int?>("JerseyNumber");

                    b.Property<int>("PlayerID");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int>("TeamID");

                    b.HasKey("PlayerAssignmentId");

                    b.HasIndex("PlayerID");

                    b.HasIndex("TeamID");

                    b.ToTable("PlayerToTeamAssignments");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.TeamEntity", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CrestURL");

                    b.Property<string>("MarektValue");

                    b.Property<string>("Name");

                    b.Property<string>("ShortName");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.TeamToCompetitionAssignmentEntity", b =>
                {
                    b.Property<int>("TeamAssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompetitionId");

                    b.Property<int>("TeamId");

                    b.HasKey("TeamAssignmentId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamToCompetitionAssignments");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.CompetitionEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.NationalityEntity", "Nationality")
                        .WithMany("Competitions")
                        .HasForeignKey("NationalityId");
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.GameEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.TeamEntity", "AwayTeam")
                        .WithMany("AwayGames")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SportsScoresAPI.Models.Entities.CompetitionEntity", "Competition")
                        .WithMany("Games")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.TeamEntity", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.GameEventEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.GameEntity", "Game")
                        .WithMany("GameEvents")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.PlayerEntity", "Player")
                        .WithMany("GameEvents")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.TeamEntity", "Team")
                        .WithMany("GameEvents")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.GameSquadAssignmentEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.GameEntity", "Game")
                        .WithMany("GameSquadAssignments")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.PlayerEntity", "PLayer")
                        .WithMany("GameSquadAssignments")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.TeamEntity", "Team")
                        .WithMany("GameSquadAssignments")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.PlayerEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.NationalityEntity", "Nationality")
                        .WithMany("Players")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.PlayerPositionEntity", "PlayerPosition")
                        .WithMany("Players")
                        .HasForeignKey("PlayerPositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.PlayerToTeamAssignmentEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.PlayerEntity", "Player")
                        .WithMany("PlayerAssignments")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.TeamEntity", "Team")
                        .WithMany("PlayerAssignments")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsScoresAPI.Models.Entities.TeamToCompetitionAssignmentEntity", b =>
                {
                    b.HasOne("SportsScoresAPI.Models.Entities.CompetitionEntity", "Competition")
                        .WithMany("TeamAssignments")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsScoresAPI.Models.Entities.TeamEntity", "Team")
                        .WithMany("TeamAssignments")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
