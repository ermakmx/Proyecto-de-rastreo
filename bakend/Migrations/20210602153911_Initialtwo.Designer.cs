// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelos;

namespace bakend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210602153911_Initialtwo")]
    partial class Initialtwo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("modelos.ent_sal", b =>
                {
                    b.Property<int>("EntSalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Entrada")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tinyint");

                    b.Property<int>("GLId")
                        .HasColumnType("int");

                    b.Property<int>("RecursoId")
                        .HasColumnType("int");

                    b.Property<byte>("Salida")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tinyint");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.HasKey("EntSalId");

                    b.HasIndex("GLId");

                    b.HasIndex("RecursoId");

                    b.ToTable("EntradasSalidas");
                });

            modelBuilder.Entity("modelos.geolug", b =>
                {
                    b.Property<int>("GLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LugId")
                        .HasColumnType("int");

                    b.Property<int?>("LugarId")
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.HasKey("GLId");

                    b.HasIndex("LugarId");

                    b.ToTable("geolugares");
                });

            modelBuilder.Entity("modelos.lugar", b =>
                {
                    b.Property<int>("LugarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("latitud")
                        .HasColumnType("float");

                    b.Property<double>("longitud")
                        .HasColumnType("float");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LugarId");

                    b.ToTable("Lugar");
                });

            modelBuilder.Entity("modelos.movimiento", b =>
                {
                    b.Property<int>("MovId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("FFin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tinyint");

                    b.Property<byte>("FInicio")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tinyint");

                    b.Property<int>("RecursoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.HasKey("MovId");

                    b.HasIndex("RecursoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Usu_Rec");
                });

            modelBuilder.Entity("modelos.posicion", b =>
                {
                    b.Property<int>("PosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("FStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("tinyint");

                    b.Property<int>("RecursoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("latitud")
                        .HasColumnType("float");

                    b.Property<double>("longitud")
                        .HasColumnType("float");

                    b.HasKey("PosId");

                    b.HasIndex("RecursoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("posiciones");
                });

            modelBuilder.Entity("modelos.punto", b =>
                {
                    b.Property<int>("PuntoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GLId")
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<double>("latitud")
                        .HasColumnType("float");

                    b.Property<double>("longitud")
                        .HasColumnType("float");

                    b.HasKey("PuntoId");

                    b.HasIndex("GLId");

                    b.ToTable("puntos");
                });

            modelBuilder.Entity("modelos.recurso", b =>
                {
                    b.Property<int>("RecursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecursoId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("modelos.usuario", b =>
                {
                    b.Property<int>("Usuarioid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usuarioid");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("modelos.ent_sal", b =>
                {
                    b.HasOne("modelos.geolug", "geolug")
                        .WithMany()
                        .HasForeignKey("GLId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("modelos.recurso", "recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("geolug");

                    b.Navigation("recurso");
                });

            modelBuilder.Entity("modelos.geolug", b =>
                {
                    b.HasOne("modelos.lugar", "lugar")
                        .WithMany()
                        .HasForeignKey("LugarId");

                    b.Navigation("lugar");
                });

            modelBuilder.Entity("modelos.movimiento", b =>
                {
                    b.HasOne("modelos.recurso", "recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("modelos.usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("recurso");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("modelos.posicion", b =>
                {
                    b.HasOne("modelos.recurso", "recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("modelos.usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("recurso");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("modelos.punto", b =>
                {
                    b.HasOne("modelos.geolug", "geolug")
                        .WithMany()
                        .HasForeignKey("GLId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("geolug");
                });
#pragma warning restore 612, 618
        }
    }
}
