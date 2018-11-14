﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using StuEntities;
using EntityFramework.Extensions;
using StuContext;



namespace StuContext.Migrations
{
   public class StudetntSeed
    {
        public static void Seed(StuuuContext context)
        {
            var c1 = context.DepartMent.SingleOrDefault(x => x.Name == "电子信息工程学院");
            var c2 = context.DepartMent.SingleOrDefault(x => x.Name == "机电工程学院");
            var c3 = context.DepartMent.SingleOrDefault(x => x.Name == "贸易旅游学院");
            var c4 = context.DepartMent.SingleOrDefault(x => x.Name == "汽车工程学院");
            var c5 = context.DepartMent.SingleOrDefault(x => x.Name == "财经与物流学院");

            for (var i = 0; i < 200; i++)
            {
                string fname = "";
                string lname = "";
                var fullName = _GetRandomChineseFullName(ref fname, ref lname);

                var s1 = new Studetnt()
                {
                    StudentNo = i.ToString("DZ20170000"),
                    Name = fullName,
                    Birthday = DateTime.Now,
                    DepartMent = c1,
                    Phone = "10086",
                    Address = "社湾路"

                };
                var s2 = new Studetnt()
                {
                    StudentNo = i.ToString("JD20170000"),
                    Name = fullName,
                    Birthday = DateTime.Now,
                    DepartMent = c2,
                    Phone = "10086",
                    Address = "天堂路"

                };
                var s3 = new Studetnt()
                {
                    StudentNo = i.ToString("MY20170000"),
                    Name = fullName,
                    Birthday = DateTime.Now,
                    DepartMent = c3,
                    Phone = "10086",
                    Address = "地狱路"

                };
                var s4 = new Studetnt()
                {
                    StudentNo = i.ToString("QC20170000"),
                    Name = fullName,
                    Birthday = DateTime.Now,
                    DepartMent = c4,
                    Phone = "10086",
                    Address = "没路"

                };
                var s5 = new Studetnt()
                {
                    StudentNo = i.ToString("CJ20170000"),
                    Name = fullName,
                    Birthday = DateTime.Now,
                    DepartMent = c5,
                    Phone = "10086",
                    Address = "大道路"

                };
                context.Studetnt.Add(s1);
                context.Studetnt.Add(s2);
                context.Studetnt.Add(s3);
                context.Studetnt.Add(s4);
                context.Studetnt.Add(s5);
                Thread.Sleep(3);
            }
            context.SaveChanges();
        }

        private static string _GetRandomChineseFullName(ref string firstName,ref string lasrName)
        {
            string[] _seedFirstName = new string[] {
                "赵","钱","孙","李","周","吴","郑","王","冯","陈","褚","卫",
                "蒋","沈","韩","杨","朱","秦","尤","许","何","吕","施","张",
                "孔","曹","严","华","金","魏","陶","姜","戚","谢","邹","喻",
                "柏","水","窦","章","云","苏","潘","葛","奚","范","彭","郎",
                "鲁","韦","昌","马","苗","凤","花","方","俞","任","袁","柳",
                "酆","鲍","史","唐","费","廉","岑","薛","雷","贺","倪","汤",
                "滕","殷","罗","毕","郝","邬","安","常","乐","于","时","傅",
                "皮","卞","齐","康","伍","余","元","卜","顾","孟","平","黄",
                "和","穆","萧","尹","姚","邵","湛","汪","祁","毛","禹","狄",
                "米","贝","明","臧","计","伏","成","戴","谈","宋","茅","庞",
                "熊","纪","舒","屈","项","祝","董","梁","杜","阮","蓝","闵",
                "席","季","麻","强","贾","路","娄","危","江","童","颜","郭",
                "梅","盛","林","刁","钟","徐","邱","骆","高","夏","蔡","田",
                "樊","胡","凌","霍","虞","万","支","柯","咎","管","卢","莫",
                "经","房","裘","缪","干","解","应","宗","宣","丁","贲","邓",
                "郁","单","杭","洪","包","诸","左","石","崔","吉","钮","龚",
                "程","嵇","邢","滑","裴","陆","荣","翁","荀","羊","於","惠",
                "甄","魏","加","封","芮","羿","储","靳","汲","邴","糜","松",
                "井","段","富","巫","乌","焦","巴","弓","牧","隗","山","谷",
                "车","侯","宓","蓬","全","郗","班","仰","秋","仲","伊","宫",
                "宁","仇","栾","暴","甘","钭","厉","戎","祖","武","符","刘",
                "姜","詹","束","龙","叶","幸","司","韶","郜","黎","蓟","薄",
                "印","宿","白","怀","蒲","台","从","鄂","索","咸","籍","赖",
                "卓","蔺","屠","蒙","池","乔","阴","郁","胥","能","苍","双",
                "闻","莘","党","翟","谭","贡","劳","逄","姬","申","扶","堵",
                "冉","宰","郦","雍","却","璩","桑","桂","濮","牛","寿","通",
                "边","扈","燕","冀","郏","浦","尚","农","温","别","庄","晏",
                "柴","瞿","阎","充","慕","连","茹","习","宦","艾","鱼","容",
                "向","古","易","慎","戈","廖","庚","终","暨","居","衡","步",
                "都","耿","满","弘","匡","国","文","寇","广","禄","阙","东",
                "殴","殳","沃","利","蔚","越","夔","隆","师","巩","厍","聂",
                "晁","勾","敖","融","冷","訾","辛","阚","那","简","饶","空",
                "曾","毋","沙","乜","养","鞠","须","丰","巢","关","蒯","相",
                "查","后","江","红","游","竺","权","逯","盖","益","桓","公",
                "万","俟","司","马","上","官","欧","阳","夏","侯","诸","葛",
                "闻","人","东","方","赫","连","皇","甫","尉","迟","公","羊",
                "澹","台","公","冶","宗","政","濮","阳","淳","于","仲","孙",
                "太","叔","申","屠","公","孙","乐","正","轩","辕","令","狐",
                "钟","离","闾","丘","长","孙","慕","容","鲜","于","宇","文",
                "司","徒","司","空","亓","官","司","寇","仉","督","子","车",
                "颛","孙","端","木","巫","马","公","西","漆","雕","乐","正",
                "壤","驷","公","良","拓","拔","夹","谷","宰","父","谷","粱",
                "晋","楚","阎","法","汝","鄢","涂","钦","段","干","百","里",
                "东","郭","南","门","呼","延","归","海","羊","舌","微","生",
                "岳","帅","缑","亢","况","后","有","琴","梁","丘","左","丘",
                "东","门","西","门","商","牟","佘","佴","伯","赏","南","宫",
                "墨","哈","谯","笪","年","爱","阳","佟","第","五","言","福",
                "百","家","姓","续"
            };
            string[] _seeLastName = new string[] {
                "佳","奕","子","儒","存","翌","浩","明","鸿","林","家","彦",
                "亦","茗","乾","洋","志","川","辰","丞","贞","玮","瑾","皓",
                "友","懿","昱","晨","连","予","浩","鹏","楷","耘","泽","硕",
                "瀚","诚","珂","昱","浩","弈","伟","善","伟","君","夏","荷",
                "振","赫","华","孺","安","福","昀","程","元","鸣","宏","发",
                "美","联","海","辉","俊","宁","博","梓","尚","君","元","恺",
                "瀚","宁","尉","菡","亦","诗","晗","胥","昇","翱","辉","元",
                "润","梓","皓","亦","恺","悦","欣","淳","炎","亿","昌","铭",
                "宣","礼","钟","启","抒","桐","忠","林","炜","豪","岳","峪",
                "熙","梵","宇","元","峻","勋","泽","海","歆","宁","御","嘉",
                "汉","成","韬","宇","宁","思","柏","桓","厚","铭","衡","羽",
                "伊","杰","晗","懿","抒","萱","元","智","光","临","抒","廷",
                "鸿","诚","洁","瑞","锦","丰","学","才","骏","贤","康","睿",
                "懿","柏","亿","烨","美","学","家","洋","泽","城","启","合",
                "伟","铭","瀚","智","旭","嘉","轶","凡" };

            var rnd = new Random(DateTime.Now.Millisecond);
            firstName = _seedFirstName[rnd.Next(_seedFirstName.Length - 1)];
            lasrName = _seeLastName[rnd.Next(_seeLastName.Length - 1)]+ _seeLastName[rnd.Next(_seeLastName.Length - 1)];
            return firstName + lasrName;
        }

        //private static void _GarbageClear()
        //{
        //    var dbcontext = new StuDBContext();
        //    var stu = dbcontext.Studetnt.DistinctBy(x => x.Name).ToList();
        //    foreach (var s in stu)
        //        dbcontext.Studetnt.Where(x => x.Name == s.Name && x.ID != s.ID).Delete();
        //}
    }
}
