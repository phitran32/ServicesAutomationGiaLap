using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToolsApp.Helper;
using System.Drawing;

namespace AutoSendCapNhapDH
{
    public class MyTask
    {
        #region Trừ Ác
        public void _PostAPIMaHang(string taskname)
        {
            try
            {
                List<string> ListDevices = KAutoHelper.ADBHelper.GetDevices(); 

                if (ListDevices != null && ListDevices.Count > 0)
                {
                    foreach (var deviceID in ListDevices)
                    {
                        Task t = new Task(() =>
                        {
                            DateTime startTimeStart = DateTime.Now;
                            TimeSpan durationStart = TimeSpan.FromMinutes(15);
                            while (DateTime.Now - startTimeStart < durationStart)
                            {
                                //STOP = stop(isStop);
                                KAutoHelper.ADBHelper.Tap(deviceID, 274.9, 916.3);

                                // Logic for Khieu Chien Cao Thu
                                var TopUp_Image = BitMap_TopUp.Load_data(@"KhieuChienTruAc\TinhNang.png");                                                          
                                var TopUp_Image_XacNhan1 = BitMap_TopUp.Load_data(@"KhieuChienTruAc\XacNhan.png");
                                var TopUp_Image_LuotKhieuChien = BitMap_TopUp.Load_data(@"KhieuChienTruAc\LuotKhieuChien.png");
                                var TopUp_Image_X01 = BitMap_TopUp.Load_data(@"KhieuChienTruAc\X01.png");
                                var TopUp_Image_TruAc = BitMap_TopUp.Load_data(@"KhieuChienTruAc\TruAc.png");
                                var TopUp_Image_Down = BitMap_TopUp.Load_data(@"KhieuChienTruAc\Down.png");
                                var TopUp_Image_Dong = BitMap_TopUp.Load_data(@"KhieuChienTruAc\Dong.png");
                                var TopUp_Image_BossDie = BitMap_TopUp.Load_data(@"KhieuChienTruAc\BossDie.png");
                                var TopUp_Image_SanBoss = BitMap_TopUp.Load_data(@"KhieuChienTruAc\SanBoss.png");
                                var TopUp_Image_LKCTruAcs = BitMap_TopUp.Load_data(@"KhieuChienTruAc\LKCTruAc.png");
                                var TopUp_Image_ThongBaoCaoNhan = BitMap_TopUp.Load_data(@"KhieuChienTruAc\HuyBo.png");
                                //var Screen1 = CaptureHelper.CaptureScreen(); 
                                var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint((Bitmap)Screen, TopUp_Image);
                                if (topUp != null)
                                {
                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);delay(1);
                                    while(true)
                                    {
                                        ADBHelper.SwipeByPercent(deviceID, 71.1, 70.0, 72.6, 35.5); delay(2);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if(topUp != null)
                                        {
                                            break;
                                        }

                                        ADBHelper.SwipeByPercent(deviceID, 74.7, 22.3, 80.7, 39.2); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if (topUp != null)
                                        {
                                            break;
                                        }

                                        ADBHelper.SwipeByPercent(deviceID, 74.7, 22.3, 80.7, 39.2); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if (topUp != null)
                                        {
                                            break;
                                        }

                                        ADBHelper.SwipeByPercent(deviceID, 74.7, 22.3, 80.7, 39.2); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if (topUp != null)
                                        {
                                            break;
                                        }

                                        ADBHelper.SwipeByPercent(deviceID, 74.7, 22.3, 80.7, 39.2); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if (topUp != null)
                                        {
                                            break;
                                        }

                                        ADBHelper.SwipeByPercent(deviceID,  80.7, 39.2, 74.7, 22.3); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if (topUp != null)
                                        {
                                            break;
                                        }

                                        ADBHelper.SwipeByPercent(deviceID, 80.7, 39.2, 74.7, 22.3); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_SanBoss);
                                        if (topUp != null)
                                        {
                                            break;
                                        }
                                    }
                                    if (topUp != null)
                                    {
                                        KAutoHelper.ADBHelper.Tap(deviceID, 297, topUp.Value.Y);
                                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 62.9, 86.5);
                                        delay(2);

                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Down);
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                        delay(1);

                                        KAutoHelper.ADBHelper.Tap(deviceID, 479.7, 492.0); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_BossDie);
                                        if (topUp == null)
                                        {
                                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 71.7, 75.6); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_ThongBaoCaoNhan);
                                            if (topUp != null)
                                            {
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 36.5, 59.9);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                List<string> a = new List<string>();
                                                a.Add(deviceID);
                                                _KhieuChienCaoNhan(a);
                                                break;
                                            }

                                            while (true)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                                    delay(1);
                                                }
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Dong);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                                    delay(1);
                                                }
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Down);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                            }
                                        }

                                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 87.6, 40.1); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_BossDie);
                                        if (topUp == null)
                                        {
                                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 71.7, 75.6); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_ThongBaoCaoNhan);
                                            if (topUp != null)
                                            {
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 36.5, 59.9);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                List<string> a = new List<string>();
                                                a.Add(deviceID);
                                                _KhieuChienCaoNhan(a);
                                                break;
                                            }

                                            while (true)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                                    delay(1);
                                                }
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Down);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                            }
                                        }


                                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 87.0, 29.7); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_BossDie);
                                        if (topUp == null)
                                        {
                                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 71.7, 75.6); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_ThongBaoCaoNhan);
                                            if (topUp != null)
                                            {
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 36.5, 59.9);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                List<string> a = new List<string>();
                                                a.Add(deviceID);
                                                _KhieuChienCaoNhan(a);
                                                break;
                                            }

                                            while (true)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                                    delay(1);
                                                }
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Down);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                            }
                                        }


                                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 87.6, 17.6); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_BossDie);
                                        if (topUp == null)
                                        {
                                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 71.7, 75.6); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_ThongBaoCaoNhan);
                                            if (topUp != null)
                                            {
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 36.5, 59.9);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                                                List<string> a = new List<string>();
                                                a.Add(deviceID);
                                                _KhieuChienCaoNhan(a);
                                                break;
                                            }
                                            while (true)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                                    delay(1);
                                                }
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Down);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_LKCTruAcs);
                                        if (topUp != null)
                                        {
                                            List<string> a = new List<string>();
                                            a.Add(deviceID);
                                            _KhieuChienCaoNhan(a);
                                            break;
                                        }


                                    }
                                }
                                delay(2);

                                //KhieuChienCaoNhan(deviceID);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.6, 94.4);
                                //var topUpKCCT = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_KCCaoThu);
                                return;
                            }
                        });
                        t.Start();

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
        #region delay
        static void delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                delay--;
                if (delay == 0)
                {
                    break;
                }

            }
        }
        #endregion
        #region Khiêu chiến cao nhân

        public static void _KhieuChienCaoNhan(List<string> ListDevices)
        {

            //List<string> ListDevices = KAutoHelper.ADBHelper.GetDevices();
            foreach (var deviceID in ListDevices)
            {

                var TopUp_Image_CaoNhan = BitMap_TopUp.Load_data(@"KhieuChienTruAc\CaoNhan.png");
                var TopUp_Image_XacNhan1 = BitMap_TopUp.Load_data(@"KhieuChienTruAc\XacNhan1.png");
                var TopUp_Image_LuotKhieuChien = BitMap_TopUp.Load_data(@"KhieuChienTruAc\LuotKhieuChien.png");
                var TopUp_Image_ThongBaoCaoNhan = BitMap_TopUp.Load_data(@"KhieuChienTruAc\HuyBo.png");
                var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_CaoNhan);
                if (topUp != null)
                {
                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                    delay(3);

                    for (int i = 0; i < 5; i++)
                    {
                       

                        KAutoHelper.ADBHelper.Tap(deviceID, 453.7, 272.6); delay(1);
                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_ThongBaoCaoNhan);
                        if (topUp != null)
                        {
                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 36.5, 59.9);
                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.9, 96.6);
                            break;
                        }
                        while (true)
                        {

                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                            if (topUp != null)
                            {
                                ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                delay(1);
                                break;
                            }
                            else
                            {
                                delay(25);
                                break;
                            }

                        }
                    }
                }
                KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.6, 96.1); delay(1);

                return;

            }
        }
        #endregion
        #region Thông thien + Toàn Dân
        public void _ThongThienThap(string taskname)
        {
            DateTime today = DateTime.Now;
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string thongthien = "";
            string toandan = "";
            switch(dayOfWeek)
            {
                case DayOfWeek.Monday:
                    thongthien = "T";
                    break;
                case DayOfWeek.Tuesday:
                    toandan = "D";
                    break;
                case DayOfWeek.Wednesday:
                    thongthien = "T";
                    break;
                case DayOfWeek.Thursday:
                    toandan = "D";
                    break;
                case DayOfWeek.Friday:
                    thongthien = "T";
                    break;
                case DayOfWeek.Saturday:
                    toandan = "D";
                    break;
            }    
            if(thongthien == "T")
            {
                List<string> ListDevices = KAutoHelper.ADBHelper.GetDevices();
                if (ListDevices != null && ListDevices.Count > 0)
                {
                    //var deviceID = devices[1];
                    foreach (var deviceID in ListDevices)
                    {
                        Task t = new Task(() =>
                        {
                            DateTime startTimeStart = DateTime.Now;
                            TimeSpan durationStart = TimeSpan.FromMinutes(28);
                            while (DateTime.Now - startTimeStart < durationStart)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 274.9, 916.3);
                                delay(2);

                                var TopUp_Image = BitMap_TopUp.Load_data(@"KhieuChienTruAc\TinhNang.png");
                                var TopUp_Image_TangDa = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\TuongCoc.png");
                                var TopUp_Image_NPCTangKinhCac = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\SHXT.png");
                                var TopUp_Image_ThongThienThap = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\ThongThienThap.png");
                                var TopUp_Image_XacNhan1 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\CaoNhan\XacNhan1.png");
                                var TopUp_Image_MatNu = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\MatNu.png");
                                var TopUp_Image_Nu = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\Nu.png");
                                var TopUp_Image_Rua = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\Rua.png");
                                var TopUp_Image_100 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\TimDuong.png");
                                var TopUp_Image_50 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\TimDuong.png");
                                var TopUp_Image_Cong = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\Cong.png");

                                var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint((Bitmap)Screen, TopUp_Image);
                                if (topUp != null)
                                {
                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 33.7, 80.0); delay(1);
                                    ADBHelper.SwipeByPercent(deviceID, 71.1, 70.0, 72.6, 35.5); delay(2);
                                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 55.1, 31.4);

                                    DateTime startTime = DateTime.Now;
                                    TimeSpan duration = TimeSpan.FromMinutes(28);
                                    #region Bắt đầu chạy 30p
                                    while (DateTime.Now - startTime < duration)
                                    {
                                        #region Mặt Nữ
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_MatNu);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(5);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                delay(40);
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(5);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                        #region Nữ
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Nu);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(5);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                delay(40);
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(5);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                        #region Rùa
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Rua);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(5);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                delay(40);
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(5);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                        #region 100
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_100);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(15);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                delay(40);
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(5);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                        #region 50
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_50);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(15);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                delay(40);
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(5);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                    }
                                    #endregion

                                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.6, 94.4);
                                    return;

                                }
                            }
                        });
                        t.Start();

                    }
                }
            }    
            if(toandan == "D")
            {
                List<string> devices = KAutoHelper.ADBHelper.GetDevices();
                if (devices != null && devices.Count > 0)
                {
                    foreach (var deviceID in devices)
                    {
                        Task t = new Task(() =>
                        {
                            DateTime startTimes = DateTime.Now;
                            TimeSpan durations = TimeSpan.FromMinutes(28);
                            while (DateTime.Now - startTimes < durations)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, 274.9, 916.3);
                                delay(2);

                                // Logic for Khieu Chien Cao Thu
                                var TopUp_Image = BitMap_TopUp.Load_data(@"KhieuChienTruAc\TinhNang.png");
                                var TopUp_Image_XacNhan1 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\CaoNhan\XacNhan1.png");
                                var TopUp_Image_MatNu = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ToanDanLoanDau\NV1.png");
                                var TopUp_Image_Nu = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ToanDanLoanDau\NV2.png");
                                var TopUp_Image_Rua = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ToanDanLoanDau\NV3.png");
                                var TopUp_Image_100 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ToanDanLoanDau\Vang.png");
                                var TopUp_Image_50 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ToanDanLoanDau\Dong.png");
                                var TopUp_Image_KC = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ToanDanLoanDau\KimCuong.png");
                                var TopUp_Image_Cong = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\Cong.png");
                                var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image);
                                if (topUp != null)
                                {
                                    ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(2);
                                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 34.3, 80.2); delay(1);
                                    ADBHelper.SwipeByPercent(deviceID, 71.1, 70.0, 72.6, 35.5); delay(2);
                                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 55.1, 22.5); delay(2);

                                    DateTime startTime = DateTime.Now;
                                    TimeSpan duration = TimeSpan.FromMinutes(27);
                                    #region Bắt đầu chạy 30p
                                    while (DateTime.Now - startTime < duration)
                                    {
                                        #region Mặt Nữ
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_MatNu);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(25);
                                                    break;
                                                }
                                            }

                                        }
                                        #endregion
                                        #region Nữ
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Nu);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(25);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                        #region Rùa
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Rua);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            while (topUp == null)
                                            {
                                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                                if (topUp != null)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    delay(25);
                                                    break;
                                                }
                                            }

                                        }
                                        delay(1);
                                        #endregion
                                        #region Rương vàng
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_100);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(12);

                                        }
                                        #endregion
                                        #region rương đồng
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_50);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(12);
                                        }
                                        #endregion
                                        #region Rương kim cương
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_KC);
                                        if (topUp != null)
                                        {
                                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(12);
                                        }
                                        delay(2);
                                        #endregion
                                    }
                                    #endregion
                                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 49.7, 95.8);delay(1);
                                    return;
                                }

                            }
                        });
                        t.Start();

                    }
                }
            }    

            
        }
        #endregion
        #region Boss Bang
        public void startBossBang(string taskname)
        {
            List<string> devices = KAutoHelper.ADBHelper.GetDevices();
            if (devices != null && devices.Count > 0)
            {
                //var deviceID = devices[1];
                foreach (var deviceID in devices)
                {
                    Task t = new Task(() =>
                    {
                        DateTime startTimeStart = DateTime.Now;
                        TimeSpan durationStart = TimeSpan.FromMinutes(15);
                        while (DateTime.Now - startTimeStart < durationStart)
                        {
                            KAutoHelper.ADBHelper.Tap(deviceID, 266.7, 929.3);
                            delay(2);

                            // Logic for Khieu Chien Cao Thu
                            var TopUp_Image = BitMap_TopUp.Load_data(@"KhieuChienTruAc\TinhNang.png");
                            var TopUp_Image_XacNhan1 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\CaoNhan\XacNhan1.png");
                            var TopUp_Image_Cong = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\Cong.png");
                            var TopUp_Image_BossBang = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\BossBang1.png");
                            var TopUp_Image_DangTrongPhoBan = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\DangTrongPhoBan.png");
                            var TopUp_Image_X01 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\X01.png");
                            var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                            var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image);
                            if (topUp != null)
                            {
                                ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(2);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 36.2, 80.9); delay(2);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 55.1, 44.5); delay(2);

                                DateTime startTime = DateTime.Now;
                                TimeSpan duration = TimeSpan.FromMinutes(15);
                                #region Bắt đầu chạy 15p
                                while (DateTime.Now - startTime < duration)
                                {
                                    Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                    topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_BossBang);
                                    if (topUp != null)
                                    {
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(4);

                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_X01);
                                        if (topUp != null)
                                        {
                                            KAutoHelper.ADBHelper.Tap(deviceID, 401.7, 703.3); delay(1);
                                            KAutoHelper.ADBHelper.Tap(deviceID, 401.7, 703.3);
                                        }

                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                        while (topUp == null)
                                        {
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            if (topUp != null)
                                            {
                                                ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                                break;
                                            }
                                            else
                                            {
                                                delay(5);
                                                break;
                                            }
                                        }
                                    }

                                }
                                #endregion
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 95.8, 97.5);
                                delay(2);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 48.5, 95.3);
                            }


                        }
                        KAutoHelper.ADBHelper.Tap(deviceID, 502.4, 927.7);
                        return;
                    });
                    t.Start();

                }
            }
        }
        #endregion
        #region Lũng Bát
        public void _LungBat(string taskname)
        {
            List<string> devices = KAutoHelper.ADBHelper.GetDevices();
            if (devices != null && devices.Count > 0)
            {
                //var deviceID = devices[1];
                foreach (var deviceID in devices)
                {
                    Task t = new Task(() =>
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.6, 95.1); 
                        delay(4);

                        // Logic for Khieu Chien Cao Thu
                        var TopUp_Image = BitMap_TopUp.Load_data(@"LungBat\DaTau.png");
                        var TopUp_Image_HetLuot = BitMap_TopUp.Load_data(@"LungBat\HetLuot.png");
                        var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                        var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image);
                        if (topUp != null)
                        {
                            ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(2);
                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 30.1, 86.1); delay(1);

                            for(int i = 0; i < 5; i++)
                            {
                                Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_HetLuot);
                                if(topUp != null)
                                {
                                    break;
                                }    
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 70.8, 74.6); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 29.8, 78.3); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 71.7, 77.8); delay(5);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 47.9, 69.9); delay(1);
                            }
                            delay(2);
                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 46.4, 80.5); delay(1);
                            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.6, 95.1); delay(1);

                            var TopUp_Image_NhanOnline = BitMap_TopUp.Load_data(@"NhanThuong\QuaOnline.png");
                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_NhanOnline);
                            if (topUp != null)
                            {
                                ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                delay(2);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 27.1, 43.8); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 42.8, 43.6); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 53.9, 44.6); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 72.0, 44.6); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 27.4, 53.3); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 43.7, 54.0); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 57.2, 52.3); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 74.1, 53.1); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 27.7, 62.4); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 43.4, 62.8); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 56.3, 62.3); delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 74.4, 61.6); delay(1);
                                delay(1);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 46.4, 80.5);
                            }
                        }
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 50.6, 95.1);
                        return;
                    });
                    t.Start();

                }
            }
        }
        #endregion
        #region Bang Chiến
        public void _bangchien(string taskname)
        {
            List<string> devices = KAutoHelper.ADBHelper.GetDevices();
            if (devices != null && devices.Count > 0)
            {
                foreach (var deviceID in devices)
                {
                    Task t = new Task(() =>
                    {
                        DateTime startTimes = DateTime.Now;
                        TimeSpan durations = TimeSpan.FromMinutes(28);
                        while (DateTime.Now - startTimes < durations)
                        {
                            KAutoHelper.ADBHelper.Tap(deviceID, 274.9, 916.3);
                            KAutoHelper.ADBHelper.Tap(deviceID, 274.9, 916.3);
                            delay(2);

                            // Logic for Khieu Chien Cao Thu
                            var TopUp_Image = BitMap_TopUp.Load_data(@"KhieuChienTruAc\TinhNang.png");
                            var TopUp_Image_XacNhan1 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\CaoNhan\XacNhan1.png");
                            var TopUp_Image_Ngua = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\BangHoi\Ngua.png");
                            var TopUp_Image_NVNam = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\BangHoi\NVNam.png");
                            var TopUp_Image_NVNam1 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\BangHoi\NVNam1.png");
                            var TopUp_Image_NVNu = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\BangHoi\NVNu.png");
                            var TopUp_Image_NVNu1 = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\BangHoi\NVNu1.png");
                            var TopUp_Image_KC = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\BangHoi\KimCuong.png");
                            var TopUp_Image_Cong = BitMap_TopUp.Load_data(@"KhieuChienCaoThu\ThongThienThap\Cong.png");
                            var Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                            var topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image);
                            if (topUp != null)
                            {
                                ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(2);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 34.3, 80.2); delay(1);
                                ADBHelper.SwipeByPercent(deviceID, 71.1, 70.0, 72.6, 35.5); delay(2);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 56.3, 59.9);

                                DateTime startTime = DateTime.Now;
                                TimeSpan duration = TimeSpan.FromMinutes(27);
                                #region Bắt đầu chạy 30p
                                while (DateTime.Now - startTime < duration)
                                {
                                    #region Ngựa
                                    Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                    topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_Ngua);
                                    if (topUp != null)
                                    {
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); 
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                        while (topUp == null)
                                        {
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            if (topUp != null)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                delay(20);
                                                break;
                                            }
                                        }

                                    }
                                    #endregion
                                    #region Nam1
                                    Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                    topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_NVNam);
                                    if (topUp != null)
                                    {
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                        while (topUp == null)
                                        {
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            if (topUp != null)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                delay(20);
                                                break;
                                            }
                                        }

                                    }
                                    #endregion
                                    #region Nam
                                    Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                    topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_NVNam1);
                                    if (topUp != null)
                                    {
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); delay(1);
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                        while (topUp == null)
                                        {
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            if (topUp != null)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                delay(20);
                                                break;
                                            }
                                        }

                                    }
                                    #endregion
                                    #region NV nữ
                                    Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                    topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_NVNu);
                                    if (topUp != null)
                                    {
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); 
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                        while (topUp == null)
                                        {
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            if (topUp != null)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                delay(20);
                                                break;
                                            }
                                        }

                                    }
                                    #endregion
                                    #region NV Nữ 1
                                    Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                    topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_NVNu1);
                                    if (topUp != null)
                                    {
                                        ADBHelper.Tap(deviceID, topUp.Value.X, topUp.Value.Y); 
                                        Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                        topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                        while (topUp == null)
                                        {
                                            Screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                                            topUp = KAutoHelper.ImageScanOpenCV.FindOutPoint(Screen, TopUp_Image_XacNhan1);
                                            if (topUp != null)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                delay(20);
                                                break;
                                            }
                                        }

                                    }
                                    #endregion
                                }
                                #endregion
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 49.7, 95.8); delay(1);
                                return;
                            }

                        }
                    });
                    t.Start();

                }
            }
        }
        #endregion
    }

}
