using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OesUI
{
    public static class QueryExamState
    {
        private static string _keywordState = "all";
        private static string _sortColumn = "id";
        private static string _sortDirection = "asc";

        public static string KeywordState
        {
            get { return QueryExamState._keywordState; }
            set { QueryExamState._keywordState = value; }
        }

        public static string SortColumn
        {
            get { return QueryExamState._sortColumn; }
            set { QueryExamState._sortColumn = value; }
        }

        public static string SortDirection
        {
            get { return QueryExamState._sortDirection; }
            set { QueryExamState._sortDirection = value; }
        }
    }
}
