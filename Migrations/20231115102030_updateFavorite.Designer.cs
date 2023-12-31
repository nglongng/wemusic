﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wemusic.Controllers;

#nullable disable

namespace wemusic.Migrations
{
    [DbContext(typeof(WeMusicDbContext))]
    [Migration("20231115102030_updateFavorite")]
    partial class updateFavorite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlbumArtist", b =>
                {
                    b.Property<string>("AlbumsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ArtistsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AlbumsId", "ArtistsId");

                    b.HasIndex("ArtistsId");

                    b.ToTable("AlbumArtist");
                });

            modelBuilder.Entity("ArtistGenre", b =>
                {
                    b.Property<string>("ArtistsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenresId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ArtistsId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("ArtistGenre");
                });

            modelBuilder.Entity("FavoriteSong", b =>
                {
                    b.Property<int>("FavoritesId")
                        .HasColumnType("int");

                    b.Property<string>("SongsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FavoritesId", "SongsId");

                    b.HasIndex("SongsId");

                    b.ToTable("FavoriteSong");
                });

            modelBuilder.Entity("PlaylistSong", b =>
                {
                    b.Property<string>("PlaylistsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SongsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PlaylistsId", "SongsId");

                    b.HasIndex("SongsId");

                    b.ToTable("PlaylistSong");
                });

            modelBuilder.Entity("wemusic.Controllers.Album", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalSongs")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("wemusic.Controllers.Artist", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Followers")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("wemusic.Controllers.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("wemusic.Controllers.Genre", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("wemusic.Controllers.Playlist", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TotalSong")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("wemusic.Controllers.Song", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stream")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("albumId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("albumId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("wemusic.Controllers.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AlbumArtist", b =>
                {
                    b.HasOne("wemusic.Controllers.Album", null)
                        .WithMany()
                        .HasForeignKey("AlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wemusic.Controllers.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArtistGenre", b =>
                {
                    b.HasOne("wemusic.Controllers.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wemusic.Controllers.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FavoriteSong", b =>
                {
                    b.HasOne("wemusic.Controllers.Favorite", null)
                        .WithMany()
                        .HasForeignKey("FavoritesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wemusic.Controllers.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaylistSong", b =>
                {
                    b.HasOne("wemusic.Controllers.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wemusic.Controllers.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wemusic.Controllers.Favorite", b =>
                {
                    b.HasOne("wemusic.Controllers.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName");

                    b.Navigation("User");
                });

            modelBuilder.Entity("wemusic.Controllers.Playlist", b =>
                {
                    b.HasOne("wemusic.Controllers.User", "user")
                        .WithMany("Playlists")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("wemusic.Controllers.Song", b =>
                {
                    b.HasOne("wemusic.Controllers.Album", "album")
                        .WithMany("Songs")
                        .HasForeignKey("albumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("album");
                });

            modelBuilder.Entity("wemusic.Controllers.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("wemusic.Controllers.User", b =>
                {
                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
